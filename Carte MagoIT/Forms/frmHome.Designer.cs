namespace Carte_MagoIT.Forms
{
    partial class frmHome
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
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridConducteur = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConducteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridConducteur;
            this.searchControl1.Location = new System.Drawing.Point(2, 7);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridConducteur;
            this.searchControl1.Size = new System.Drawing.Size(951, 22);
            this.searchControl1.TabIndex = 0;
            // 
            // gridConducteur
            // 
            this.gridConducteur.Location = new System.Drawing.Point(2, 31);
            this.gridConducteur.MainView = this.gridView1;
            this.gridConducteur.Name = "gridConducteur";
            this.gridConducteur.Size = new System.Drawing.Size(1114, 557);
            this.gridConducteur.TabIndex = 1;
            this.gridConducteur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridConducteur.Click += new System.EventHandler(this.gridConducteur_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridConducteur;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1119, 600);
            this.Controls.Add(this.gridConducteur);
            this.Controls.Add(this.searchControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridConducteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl gridConducteur;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}