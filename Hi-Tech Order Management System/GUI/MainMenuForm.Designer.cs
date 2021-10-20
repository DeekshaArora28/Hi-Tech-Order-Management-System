namespace Hi_Tech_Order_Management_System.GUI
{
    partial class MainMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAndUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1310, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeAndUserToolStripMenuItem,
            this.customerFormToolStripMenuItem,
            this.booksFormToolStripMenuItem,
            this.orderFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // employeeAndUserToolStripMenuItem
            // 
            this.employeeAndUserToolStripMenuItem.Name = "employeeAndUserToolStripMenuItem";
            this.employeeAndUserToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.employeeAndUserToolStripMenuItem.Text = "Employee and User";
            this.employeeAndUserToolStripMenuItem.Click += new System.EventHandler(this.employeeAndUserToolStripMenuItem_Click_1);
            // 
            // customerFormToolStripMenuItem
            // 
            this.customerFormToolStripMenuItem.Name = "customerFormToolStripMenuItem";
            this.customerFormToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.customerFormToolStripMenuItem.Text = "CustomerForm";
            this.customerFormToolStripMenuItem.Click += new System.EventHandler(this.customerFormToolStripMenuItem_Click);
            // 
            // booksFormToolStripMenuItem
            // 
            this.booksFormToolStripMenuItem.Name = "booksFormToolStripMenuItem";
            this.booksFormToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.booksFormToolStripMenuItem.Text = "BooksForm";
            this.booksFormToolStripMenuItem.Click += new System.EventHandler(this.booksFormToolStripMenuItem_Click);
            // 
            // orderFormToolStripMenuItem
            // 
            this.orderFormToolStripMenuItem.Name = "orderFormToolStripMenuItem";
            this.orderFormToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.orderFormToolStripMenuItem.Text = "OrderForm";
            this.orderFormToolStripMenuItem.Click += new System.EventHandler(this.orderFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 507);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeAndUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}