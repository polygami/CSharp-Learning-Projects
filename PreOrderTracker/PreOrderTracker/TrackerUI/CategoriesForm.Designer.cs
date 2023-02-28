
namespace TrackerUI
{
    partial class CategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formLayout = new System.Windows.Forms.TableLayoutPanel();
            this.bodyLayout = new System.Windows.Forms.TableLayoutPanel();
            this.doneButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.contentLeftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contentRightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.listItemNameLabel = new System.Windows.Forms.Label();
            this.listItemButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ordersButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.formLayout.SuspendLayout();
            this.bodyLayout.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.contentLeftLayout.SuspendLayout();
            this.contentRightLayout.SuspendLayout();
            this.listItemButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLayout
            // 
            this.formLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formLayout.ColumnCount = 3;
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formLayout.Controls.Add(this.bodyLayout, 1, 1);
            this.formLayout.Location = new System.Drawing.Point(12, 12);
            this.formLayout.Name = "formLayout";
            this.formLayout.RowCount = 3;
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.formLayout.Size = new System.Drawing.Size(926, 830);
            this.formLayout.TabIndex = 0;
            this.formLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // bodyLayout
            // 
            this.bodyLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyLayout.ColumnCount = 1;
            this.bodyLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyLayout.Controls.Add(this.doneButton, 0, 2);
            this.bodyLayout.Controls.Add(this.displayLabel, 0, 0);
            this.bodyLayout.Controls.Add(this.contentLayout, 0, 1);
            this.bodyLayout.Location = new System.Drawing.Point(35, 35);
            this.bodyLayout.Name = "bodyLayout";
            this.bodyLayout.RowCount = 3;
            this.bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.42696F));
            this.bodyLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.bodyLayout.Size = new System.Drawing.Size(856, 760);
            this.bodyLayout.TabIndex = 0;
            this.bodyLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.contentLayout_Paint);
            // 
            // doneButton
            // 
            this.doneButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(0, 724);
            this.doneButton.Margin = new System.Windows.Forms.Padding(0);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(856, 36);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Font = new System.Drawing.Font("Roboto", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.ForeColor = System.Drawing.Color.White;
            this.displayLabel.Location = new System.Drawing.Point(3, 0);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(282, 60);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Categories";
            this.displayLabel.Click += new System.EventHandler(this.displayLabel_Click);
            // 
            // contentLayout
            // 
            this.contentLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentLayout.ColumnCount = 3;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.Controls.Add(this.contentLeftLayout, 0, 0);
            this.contentLayout.Controls.Add(this.contentRightLayout, 2, 0);
            this.contentLayout.Location = new System.Drawing.Point(3, 63);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.RowCount = 1;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.Size = new System.Drawing.Size(850, 634);
            this.contentLayout.TabIndex = 2;
            this.contentLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.contentLayout_Paint_1);
            // 
            // contentLeftLayout
            // 
            this.contentLeftLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentLeftLayout.ColumnCount = 1;
            this.contentLeftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLeftLayout.Controls.Add(this.addButton, 0, 1);
            this.contentLeftLayout.Controls.Add(this.listView1, 0, 0);
            this.contentLeftLayout.Location = new System.Drawing.Point(3, 3);
            this.contentLeftLayout.Name = "contentLeftLayout";
            this.contentLeftLayout.RowCount = 2;
            this.contentLeftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLeftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.contentLeftLayout.Size = new System.Drawing.Size(407, 628);
            this.contentLeftLayout.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(0, 592);
            this.addButton.Margin = new System.Windows.Forms.Padding(0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(407, 36);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 574);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contentRightLayout
            // 
            this.contentRightLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentRightLayout.ColumnCount = 1;
            this.contentRightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentRightLayout.Controls.Add(this.listItemNameLabel, 0, 0);
            this.contentRightLayout.Controls.Add(this.listItemButtonsLayout, 0, 2);
            this.contentRightLayout.Location = new System.Drawing.Point(440, 3);
            this.contentRightLayout.Name = "contentRightLayout";
            this.contentRightLayout.RowCount = 4;
            this.contentRightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.contentRightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.contentRightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.contentRightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentRightLayout.Size = new System.Drawing.Size(407, 628);
            this.contentRightLayout.TabIndex = 2;
            this.contentRightLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.contentRightLayout_Paint);
            // 
            // listItemNameLabel
            // 
            this.listItemNameLabel.AutoSize = true;
            this.listItemNameLabel.Font = new System.Drawing.Font("Roboto", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemNameLabel.ForeColor = System.Drawing.Color.White;
            this.listItemNameLabel.Location = new System.Drawing.Point(3, 0);
            this.listItemNameLabel.Name = "listItemNameLabel";
            this.listItemNameLabel.Size = new System.Drawing.Size(293, 45);
            this.listItemNameLabel.TabIndex = 4;
            this.listItemNameLabel.Text = "listItemName";
            this.listItemNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // listItemButtonsLayout
            // 
            this.listItemButtonsLayout.ColumnCount = 5;
            this.listItemButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.listItemButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.listItemButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.listItemButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.listItemButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.listItemButtonsLayout.Controls.Add(this.ordersButton, 0, 0);
            this.listItemButtonsLayout.Controls.Add(this.editButton, 2, 0);
            this.listItemButtonsLayout.Controls.Add(this.deleteButton, 4, 0);
            this.listItemButtonsLayout.Location = new System.Drawing.Point(3, 126);
            this.listItemButtonsLayout.Name = "listItemButtonsLayout";
            this.listItemButtonsLayout.RowCount = 1;
            this.listItemButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listItemButtonsLayout.Size = new System.Drawing.Size(401, 30);
            this.listItemButtonsLayout.TabIndex = 6;
            // 
            // ordersButton
            // 
            this.ordersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersButton.ForeColor = System.Drawing.Color.Black;
            this.ordersButton.Location = new System.Drawing.Point(0, 0);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(0);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(123, 30);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "ORDERS";
            this.ordersButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(139, 0);
            this.editButton.Margin = new System.Windows.Forms.Padding(0);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(123, 30);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(278, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 30);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(950, 854);
            this.Controls.Add(this.formLayout);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CategoriesForm";
            this.Text = "Form1";
            this.formLayout.ResumeLayout(false);
            this.bodyLayout.ResumeLayout(false);
            this.bodyLayout.PerformLayout();
            this.contentLayout.ResumeLayout(false);
            this.contentLeftLayout.ResumeLayout(false);
            this.contentRightLayout.ResumeLayout(false);
            this.contentRightLayout.PerformLayout();
            this.listItemButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel formLayout;
        private System.Windows.Forms.TableLayoutPanel bodyLayout;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TableLayoutPanel contentLayout;
        private System.Windows.Forms.TableLayoutPanel contentLeftLayout;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label listItemNameLabel;
        private System.Windows.Forms.TableLayoutPanel contentRightLayout;
        private System.Windows.Forms.TableLayoutPanel listItemButtonsLayout;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

