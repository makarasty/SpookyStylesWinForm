namespace SpookyStylesWinForm
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}


		private void InitializeComponent()
		{
			mainTableLayoutPanel = new TableLayoutPanel();
			titleLabel = new Label();
			itemNameLabel = new Label();
			itemNameTextBox = new TextBox();
			itemNameErrorLabel = new Label();
			categoryLabel = new Label();
			categoryComboBox = new ComboBox();
			categoryErrorLabel = new Label();
			sizeLabel = new Label();
			sizeComboBox = new ComboBox();
			sizeErrorLabel = new Label();
			colorLabel = new Label();
			colorTextBox = new TextBox();
			colorErrorLabel = new Label();
			priceLabel = new Label();
			priceTextBox = new TextBox();
			priceErrorLabel = new Label();
			quantityLabel = new Label();
			quantityTextBox = new TextBox();
			quantityErrorLabel = new Label();
			descriptionLabel = new Label();
			descriptionTextBox = new TextBox();
			submitButton = new Button();
			mainTableLayoutPanel.SuspendLayout();
			SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.AutoSize = true;
			mainTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			mainTableLayoutPanel.ColumnCount = 4;
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
			mainTableLayoutPanel.Controls.Add(titleLabel, 0, 0);
			mainTableLayoutPanel.Controls.Add(itemNameLabel, 0, 1);
			mainTableLayoutPanel.Controls.Add(itemNameTextBox, 0, 2);
			mainTableLayoutPanel.Controls.Add(itemNameErrorLabel, 0, 3);
			mainTableLayoutPanel.Controls.Add(categoryLabel, 1, 1);
			mainTableLayoutPanel.Controls.Add(categoryComboBox, 1, 2);
			mainTableLayoutPanel.Controls.Add(categoryErrorLabel, 1, 3);
			mainTableLayoutPanel.Controls.Add(sizeLabel, 2, 1);
			mainTableLayoutPanel.Controls.Add(sizeComboBox, 2, 2);
			mainTableLayoutPanel.Controls.Add(sizeErrorLabel, 2, 3);
			mainTableLayoutPanel.Controls.Add(colorLabel, 3, 1);
			mainTableLayoutPanel.Controls.Add(colorTextBox, 3, 2);
			mainTableLayoutPanel.Controls.Add(colorErrorLabel, 3, 3);
			mainTableLayoutPanel.Controls.Add(priceLabel, 0, 4);
			mainTableLayoutPanel.Controls.Add(priceTextBox, 0, 5);
			mainTableLayoutPanel.Controls.Add(priceErrorLabel, 0, 6);
			mainTableLayoutPanel.Controls.Add(quantityLabel, 1, 4);
			mainTableLayoutPanel.Controls.Add(quantityTextBox, 1, 5);
			mainTableLayoutPanel.Controls.Add(quantityErrorLabel, 1, 6);
			mainTableLayoutPanel.Controls.Add(descriptionLabel, 0, 7);
			mainTableLayoutPanel.Controls.Add(descriptionTextBox, 0, 8);
			mainTableLayoutPanel.Controls.Add(submitButton, 1, 9);
			mainTableLayoutPanel.Dock = DockStyle.Fill;
			mainTableLayoutPanel.Location = new Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.RowCount = 11;
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.RowStyles.Add(new RowStyle());
			mainTableLayoutPanel.Size = new Size(800, 600);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			titleLabel.AutoSize = true;
			mainTableLayoutPanel.SetColumnSpan(titleLabel, 4);
			titleLabel.Dock = DockStyle.Fill;
			titleLabel.Font = new Font("Arial", 24F);
			titleLabel.ForeColor = Color.FromArgb(255, 117, 24);
			titleLabel.Location = new Point(3, 0);
			titleLabel.Name = "titleLabel";
			titleLabel.Size = new Size(794, 36);
			titleLabel.TabIndex = 0;
			titleLabel.Text = "Додати новий предмет одягу";
			titleLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// itemNameLabel
			// 
			itemNameLabel.Anchor = AnchorStyles.Left;
			itemNameLabel.AutoSize = true;
			itemNameLabel.Location = new Point(3, 36);
			itemNameLabel.Name = "itemNameLabel";
			itemNameLabel.Size = new Size(99, 15);
			itemNameLabel.TabIndex = 1;
			itemNameLabel.Text = "Назва предмета*";
			// 
			// itemNameTextBox
			// 
			itemNameTextBox.Dock = DockStyle.Fill;
			itemNameTextBox.Location = new Point(3, 54);
			itemNameTextBox.Name = "itemNameTextBox";
			itemNameTextBox.Size = new Size(194, 23);
			itemNameTextBox.TabIndex = 2;
			itemNameTextBox.TextChanged += anyField_Changed;
			// 
			// itemNameErrorLabel
			// 
			itemNameErrorLabel.Anchor = AnchorStyles.Left;
			itemNameErrorLabel.AutoSize = true;
			itemNameErrorLabel.ForeColor = Color.Red;
			itemNameErrorLabel.Location = new Point(3, 80);
			itemNameErrorLabel.Name = "itemNameErrorLabel";
			itemNameErrorLabel.Size = new Size(0, 15);
			itemNameErrorLabel.TabIndex = 3;
			itemNameErrorLabel.Visible = false;
			// 
			// categoryLabel
			// 
			categoryLabel.Anchor = AnchorStyles.Left;
			categoryLabel.AutoSize = true;
			categoryLabel.Location = new Point(203, 36);
			categoryLabel.Name = "categoryLabel";
			categoryLabel.Size = new Size(64, 15);
			categoryLabel.TabIndex = 4;
			categoryLabel.Text = "Категорія*";
			// 
			// categoryComboBox
			// 
			categoryComboBox.Dock = DockStyle.Fill;
			categoryComboBox.Location = new Point(203, 54);
			categoryComboBox.Name = "categoryComboBox";
			categoryComboBox.Size = new Size(194, 23);
			categoryComboBox.TabIndex = 5;
			categoryComboBox.SelectedIndexChanged += anyField_Changed;
			// 
			// categoryErrorLabel
			// 
			categoryErrorLabel.Anchor = AnchorStyles.Left;
			categoryErrorLabel.AutoSize = true;
			categoryErrorLabel.ForeColor = Color.Red;
			categoryErrorLabel.Location = new Point(203, 80);
			categoryErrorLabel.Name = "categoryErrorLabel";
			categoryErrorLabel.Size = new Size(0, 15);
			categoryErrorLabel.TabIndex = 6;
			categoryErrorLabel.Visible = false;
			// 
			// sizeLabel
			// 
			sizeLabel.Anchor = AnchorStyles.Left;
			sizeLabel.AutoSize = true;
			sizeLabel.Location = new Point(403, 36);
			sizeLabel.Name = "sizeLabel";
			sizeLabel.Size = new Size(50, 15);
			sizeLabel.TabIndex = 7;
			sizeLabel.Text = "Розмір*";
			// 
			// sizeComboBox
			// 
			sizeComboBox.Dock = DockStyle.Fill;
			sizeComboBox.Location = new Point(403, 54);
			sizeComboBox.Name = "sizeComboBox";
			sizeComboBox.Size = new Size(194, 23);
			sizeComboBox.TabIndex = 8;
			sizeComboBox.SelectedIndexChanged += anyField_Changed;
			// 
			// sizeErrorLabel
			// 
			sizeErrorLabel.Anchor = AnchorStyles.Left;
			sizeErrorLabel.AutoSize = true;
			sizeErrorLabel.ForeColor = Color.Red;
			sizeErrorLabel.Location = new Point(403, 80);
			sizeErrorLabel.Name = "sizeErrorLabel";
			sizeErrorLabel.Size = new Size(0, 15);
			sizeErrorLabel.TabIndex = 9;
			sizeErrorLabel.Visible = false;
			// 
			// colorLabel
			// 
			colorLabel.Anchor = AnchorStyles.Left;
			colorLabel.AutoSize = true;
			colorLabel.Location = new Point(603, 36);
			colorLabel.Name = "colorLabel";
			colorLabel.Size = new Size(43, 15);
			colorLabel.TabIndex = 10;
			colorLabel.Text = "Колір*";
			// 
			// colorTextBox
			// 
			colorTextBox.Dock = DockStyle.Fill;
			colorTextBox.Location = new Point(603, 54);
			colorTextBox.Name = "colorTextBox";
			colorTextBox.Size = new Size(194, 23);
			colorTextBox.TabIndex = 11;
			colorTextBox.TextChanged += anyField_Changed;
			// 
			// colorErrorLabel
			// 
			colorErrorLabel.Anchor = AnchorStyles.Left;
			colorErrorLabel.AutoSize = true;
			colorErrorLabel.ForeColor = Color.Red;
			colorErrorLabel.Location = new Point(603, 80);
			colorErrorLabel.Name = "colorErrorLabel";
			colorErrorLabel.Size = new Size(0, 15);
			colorErrorLabel.TabIndex = 12;
			colorErrorLabel.Visible = false;
			// 
			// priceLabel
			// 
			priceLabel.Anchor = AnchorStyles.Left;
			priceLabel.AutoSize = true;
			priceLabel.Location = new Point(3, 99);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(37, 15);
			priceLabel.TabIndex = 13;
			priceLabel.Text = "Ціна*";
			// 
			// priceTextBox
			// 
			priceTextBox.Dock = DockStyle.Fill;
			priceTextBox.Location = new Point(3, 121);
			priceTextBox.Name = "priceTextBox";
			priceTextBox.Size = new Size(194, 23);
			priceTextBox.TabIndex = 14;
			priceTextBox.TextChanged += anyField_Changed;
			// 
			// priceErrorLabel
			// 
			priceErrorLabel.Anchor = AnchorStyles.Left;
			priceErrorLabel.AutoSize = true;
			priceErrorLabel.ForeColor = Color.Red;
			priceErrorLabel.Location = new Point(3, 151);
			priceErrorLabel.Name = "priceErrorLabel";
			priceErrorLabel.Size = new Size(0, 15);
			priceErrorLabel.TabIndex = 15;
			priceErrorLabel.Visible = false;
			// 
			// quantityLabel
			// 
			quantityLabel.Anchor = AnchorStyles.Left;
			quantityLabel.AutoSize = true;
			quantityLabel.Location = new Point(203, 99);
			quantityLabel.Name = "quantityLabel";
			quantityLabel.Size = new Size(61, 15);
			quantityLabel.TabIndex = 16;
			quantityLabel.Text = "Кількість*";
			// 
			// quantityTextBox
			// 
			quantityTextBox.Dock = DockStyle.Fill;
			quantityTextBox.Location = new Point(203, 121);
			quantityTextBox.Name = "quantityTextBox";
			quantityTextBox.Size = new Size(194, 23);
			quantityTextBox.TabIndex = 17;
			quantityTextBox.TextChanged += anyField_Changed;
			// 
			// quantityErrorLabel
			// 
			quantityErrorLabel.Anchor = AnchorStyles.Left;
			quantityErrorLabel.AutoSize = true;
			quantityErrorLabel.ForeColor = Color.Red;
			quantityErrorLabel.Location = new Point(203, 151);
			quantityErrorLabel.Name = "quantityErrorLabel";
			quantityErrorLabel.Size = new Size(0, 15);
			quantityErrorLabel.TabIndex = 18;
			quantityErrorLabel.Visible = false;
			// 
			// descriptionLabel
			// 
			descriptionLabel.Anchor = AnchorStyles.Left;
			descriptionLabel.AutoSize = true;
			mainTableLayoutPanel.SetColumnSpan(descriptionLabel, 4);
			descriptionLabel.Location = new Point(3, 170);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new Size(36, 15);
			descriptionLabel.TabIndex = 25;
			descriptionLabel.Text = "Опис";
			// 
			// descriptionTextBox
			// 
			mainTableLayoutPanel.SetColumnSpan(descriptionTextBox, 4);
			descriptionTextBox.Dock = DockStyle.Fill;
			descriptionTextBox.Location = new Point(3, 188);
			descriptionTextBox.Multiline = true;
			descriptionTextBox.Name = "descriptionTextBox";
			descriptionTextBox.ScrollBars = ScrollBars.Vertical;
			descriptionTextBox.Size = new Size(794, 144);
			descriptionTextBox.TabIndex = 26;
			// 
			// submitButton
			// 
			submitButton.Anchor = AnchorStyles.None;
			mainTableLayoutPanel.SetColumnSpan(submitButton, 2);
			submitButton.Font = new Font("Arial", 14F);
			submitButton.Location = new Point(338, 338);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(124, 32);
			submitButton.TabIndex = 27;
			submitButton.Text = "Додати предмет";
			submitButton.Click += submitButton_Click;
			// 
			// Form1
			// 
			ClientSize = new Size(800, 600);
			Controls.Add(mainTableLayoutPanel);
			MinimumSize = new Size(800, 600);
			Name = "Form1";
			Text = "Додати новий предмет одягу";
			mainTableLayoutPanel.ResumeLayout(false);
			mainTableLayoutPanel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;

		private System.Windows.Forms.Label titleLabel;

		private System.Windows.Forms.Label itemNameLabel;
		private System.Windows.Forms.TextBox itemNameTextBox;
		private System.Windows.Forms.Label itemNameErrorLabel;

		private System.Windows.Forms.Label categoryLabel;
		private System.Windows.Forms.ComboBox categoryComboBox;
		private System.Windows.Forms.Label categoryErrorLabel;

		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.ComboBox sizeComboBox;
		private System.Windows.Forms.Label sizeErrorLabel;

		private System.Windows.Forms.Label colorLabel;
		private System.Windows.Forms.TextBox colorTextBox;
		private System.Windows.Forms.Label colorErrorLabel;

		private System.Windows.Forms.Label priceLabel;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label priceErrorLabel;

		private System.Windows.Forms.Label quantityLabel;
		private System.Windows.Forms.TextBox quantityTextBox;
		private System.Windows.Forms.Label quantityErrorLabel;

		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;

		private System.Windows.Forms.Button submitButton;
	}
}
