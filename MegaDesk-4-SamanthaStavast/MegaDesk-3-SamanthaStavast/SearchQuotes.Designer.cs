namespace MegaDesk_3_SamanthaStavast
{
    partial class SearchQuotes
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
            this.returnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_material = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnHome
            // 
            this.returnHome.BackColor = System.Drawing.Color.LightGreen;
            this.returnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHome.Location = new System.Drawing.Point(16, 279);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(389, 37);
            this.returnHome.TabIndex = 69;
            this.returnHome.Text = "Return Home";
            this.returnHome.UseVisualStyleBackColor = false;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Search Quotes:";
            // 
            // search_material
            // 
            this.search_material.FormattingEnabled = true;
            this.search_material.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.search_material.Location = new System.Drawing.Point(160, 10);
            this.search_material.Name = "search_material";
            this.search_material.Size = new System.Drawing.Size(245, 24);
            this.search_material.TabIndex = 115;
            this.search_material.Text = " - Select a Material -";
            this.search_material.SelectionChangeCommitted += new System.EventHandler(this.search_material_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 223);
            this.dataGridView1.TabIndex = 116;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.returnHome;
            this.ClientSize = new System.Drawing.Size(418, 327);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_material);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.label1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox search_material;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}