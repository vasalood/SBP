namespace MotornaVozila.Forme
{
    partial class ServisiranaVozilaForm
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
            this.listVozila = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listVozila
            // 
            this.listVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listVozila.HideSelection = false;
            this.listVozila.Location = new System.Drawing.Point(16, 12);
            this.listVozila.Name = "listVozila";
            this.listVozila.Size = new System.Drawing.Size(542, 268);
            this.listVozila.TabIndex = 0;
            this.listVozila.UseCompatibleStateImageBehavior = false;
            this.listVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Broj motora";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj sasije";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kubikaza";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Boja";
            this.columnHeader5.Width = 107;
            // 
            // ServisiranaVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 287);
            this.Controls.Add(this.listVozila);
            this.MaximumSize = new System.Drawing.Size(584, 326);
            this.MinimumSize = new System.Drawing.Size(584, 326);
            this.Name = "ServisiranaVozilaForm";
            this.Text = "ServisiranaVozilaForm";
            this.Load += new System.EventHandler(this.ServisiranaVozilaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listVozila;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}