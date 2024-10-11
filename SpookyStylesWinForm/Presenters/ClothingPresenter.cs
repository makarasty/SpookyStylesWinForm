using SpookyStylesWinForm.Models;
using SpookyStylesWinForm.Views;

namespace SpookyStylesWinForm.Presenters
{
	public class ClothingPresenter
	{
		private readonly IClothingView _view;
		private readonly List<ClothingItem> _clothingItems;

		public ClothingPresenter(IClothingView view)
		{
			_view = view;
			_clothingItems = new List<ClothingItem>();

			_view.SubmitForm += OnSubmitForm;
			_view.FieldChanged += OnFieldChanged;

			LoadCategories();
			LoadSizes();
		}

		private void LoadCategories()
		{
			var categories = new List<string>
			{
				"Верхній одяг",
				"Футболки, блузи та сорочки",
				"Штани та джинси",
				"Сукні",
				"Спідниці",
				"Спортивний одяг",
				"Трикотаж",
				"Костюми",
				"Нижня білизна",
				"Аксесуари",
				"Взуття",
				"Сумки та рюкзаки"
			};
			_view.SetCategories(categories);
		}

		private void LoadSizes()
		{
			var sizes = new List<string>
			{
				"Дуже-дуже малий (XXS)",
				"Дуже малий (XS)",
				"Малий (S)",
				"Середній (M)",
				"Великий (L)",
				"Дуже великий (XL)",
				"Дуже-дуже великий (XXL)"
			};
			_view.SetSizes(sizes);
		}

		private void OnFieldChanged(object sender, EventArgs e)
		{
			// Можна реалізувати валідацію в режимі реального часу
		}

		private void OnSubmitForm(object sender, EventArgs e)
		{
			_view.ClearErrors();

			if (ValidateForm())
			{
				var clothingItem = new ClothingItem
				{
					ItemName = _view.ItemName,
					Category = _view.SelectedCategory,
					Size = _view.SelectedSize,
					ItemColor = _view.ItemColor,
					Price = _view.Price,
					Quantity = _view.Quantity,
					Description = _view.Description
				};

				_clothingItems.Add(clothingItem);

				_view.ShowMessage("Форма успішно відправлена!");

				Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(_clothingItems, new System.Text.Json.JsonSerializerOptions { WriteIndented = true }));

				ResetForm();
			}
		}

		private bool ValidateForm()
		{
			bool isValid = true;
			string firstInvalidField = null;

			if (string.IsNullOrWhiteSpace(_view.ItemName))
			{
				_view.SetError("ItemName", "Назва предмета є обов'язковою.");
				isValid = false;
				firstInvalidField ??= "ItemName";
			}

			if (string.IsNullOrEmpty(_view.SelectedCategory))
			{
				_view.SetError("Category", "Виберіть категорію.");
				isValid = false;
				firstInvalidField ??= "Category";
			}

			if (string.IsNullOrEmpty(_view.SelectedSize))
			{
				_view.SetError("Size", "Виберіть розмір.");
				isValid = false;
				firstInvalidField ??= "Size";
			}

			if (string.IsNullOrWhiteSpace(_view.ItemColor))
			{
				_view.SetError("ItemColor", "Введіть колір.");
				isValid = false;
				firstInvalidField ??= "ItemColor";
			}

			if (_view.Price <= 0)
			{
				_view.SetError("Price", "Введіть коректну ціну.");
				isValid = false;
				firstInvalidField ??= "Price";
			}

			if (_view.Quantity <= 0)
			{
				_view.SetError("Quantity", "Введіть коректну кількість.");
				isValid = false;
				firstInvalidField ??= "Quantity";
			}

			if (!isValid && firstInvalidField != null)
			{
				_view.FocusField(firstInvalidField);
			}

			return isValid;
		}

		private void ResetForm()
		{
			_view.ItemName = string.Empty;
			_view.SelectedCategory = null;
			_view.SelectedSize = null;
			_view.ItemColor = string.Empty;
			_view.Price = 0;
			_view.Quantity = 0;
			_view.Description = string.Empty;
		}
	}
}
