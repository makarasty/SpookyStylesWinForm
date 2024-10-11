using System.Text.Json;

namespace SpookyStylesWinForm
{
	public partial class Form1 : Form
	{
		private readonly List<ClothingItem> _clothingItems;

		public Form1()
		{
			InitializeComponent();
			ApplyStyles();

			_clothingItems = new List<ClothingItem>();

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
			categoryComboBox.DataSource = categories;
			categoryComboBox.SelectedIndex = -1;
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
			sizeComboBox.DataSource = sizes;
			sizeComboBox.SelectedIndex = -1;
		}

		private void ApplyStyles()
		{
			this.BackColor = Color.FromArgb(26, 26, 26);
			this.ForeColor = Color.FromArgb(244, 244, 244);
			this.Font = new Font("Arial", 10, FontStyle.Regular);

			submitButton.BackColor = Color.FromArgb(255, 117, 24);
			submitButton.ForeColor = Color.FromArgb(26, 26, 26);
			submitButton.FlatStyle = FlatStyle.Flat;

			titleLabel.Font = new Font("Arial", 24, FontStyle.Regular);
			titleLabel.ForeColor = Color.FromArgb(255, 117, 24);
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			ClearErrors();

			if (ValidateForm())
			{
				var clothingItem = new ClothingItem
				{
					ItemName = itemNameTextBox.Text.Trim(),
					Category = categoryComboBox.SelectedItem.ToString(),
					Size = sizeComboBox.SelectedItem.ToString(),
					ItemColor = colorTextBox.Text.Trim(),
					Price = decimal.Parse(priceTextBox.Text.Trim()),
					Quantity = int.Parse(quantityTextBox.Text.Trim()),
					Description = descriptionTextBox.Text.Trim()
				};

				_clothingItems.Add(clothingItem);

				MessageBox.Show("Предмет успішно додано!");

				Console.WriteLine(JsonSerializer.Serialize(_clothingItems, new JsonSerializerOptions { WriteIndented = true }));

				ResetForm();
			}
		}

		private bool ValidateForm()
		{
			bool isValid = true;

			if (string.IsNullOrWhiteSpace(itemNameTextBox.Text))
			{
				itemNameErrorLabel.Text = "Назва предмета є обов'язковою.";
				itemNameErrorLabel.Visible = true;
				isValid = false;
			}

			if (categoryComboBox.SelectedIndex == -1)
			{
				categoryErrorLabel.Text = "Виберіть категорію.";
				categoryErrorLabel.Visible = true;
				isValid = false;
			}

			if (sizeComboBox.SelectedIndex == -1)
			{
				sizeErrorLabel.Text = "Виберіть розмір.";
				sizeErrorLabel.Visible = true;
				isValid = false;
			}

			if (string.IsNullOrWhiteSpace(colorTextBox.Text))
			{
				colorErrorLabel.Text = "Введіть колір.";
				colorErrorLabel.Visible = true;
				isValid = false;
			}

			if (!decimal.TryParse(priceTextBox.Text.Trim(), out var price) || price <= 0)
			{
				priceErrorLabel.Text = "Введіть коректну ціну.";
				priceErrorLabel.Visible = true;
				isValid = false;
			}

			if (!int.TryParse(quantityTextBox.Text.Trim(), out var quantity) || quantity <= 0)
			{
				quantityErrorLabel.Text = "Введіть коректну кількість.";
				quantityErrorLabel.Visible = true;
				isValid = false;
			}

			return isValid;
		}

		private void ClearErrors()
		{
			itemNameErrorLabel.Visible = false;
			categoryErrorLabel.Visible = false;
			sizeErrorLabel.Visible = false;
			colorErrorLabel.Visible = false;
			priceErrorLabel.Visible = false;
			quantityErrorLabel.Visible = false;
		}

		private void ResetForm()
		{
			itemNameTextBox.Text = string.Empty;
			categoryComboBox.SelectedIndex = -1;
			sizeComboBox.SelectedIndex = -1;
			colorTextBox.Text = string.Empty;
			priceTextBox.Text = string.Empty;
			quantityTextBox.Text = string.Empty;
			descriptionTextBox.Text = string.Empty;
		}

		private void anyField_Changed(object sender, EventArgs e)
		{
			// Можна додати валідацію в реальному часі
		}
	}

	public class ClothingItem
	{
		public string ItemName { get; set; }
		public string Category { get; set; }
		public string Size { get; set; }
		public string ItemColor { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public string Description { get; set; }
	}
}
