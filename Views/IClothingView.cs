namespace SpookyStylesWinForm.Views
{
	public interface IClothingView
	{
		string ItemName { get; set; }
		string SelectedCategory { get; set; }
		string SelectedSize { get; set; }
		string ItemColor { get; set; }
		decimal Price { get; set; }
		int Quantity { get; set; }
		string Description { get; set; }

		void ShowMessage(string message);
		void ClearErrors();
		void SetError(string fieldName, string errorMessage);
		void FocusField(string fieldName);

		event EventHandler SubmitForm;
		event EventHandler FieldChanged;

		void SetCategories(List<string> categories);
		void SetSizes(List<string> sizes);
	}
}
