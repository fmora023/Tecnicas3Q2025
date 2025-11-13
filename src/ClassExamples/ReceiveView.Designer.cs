namespace ClassExamples
{
    partial class ReceiveView
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
            label1 = new Label();
            lblDate = new Label();
            label3 = new Label();
            lblClientName = new Label();
            label5 = new Label();
            lblPayment = new Label();
            label7 = new Label();
            lblTotals = new Label();
            lvwProducts = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 36);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(243, 36);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 78);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(243, 78);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(50, 20);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 122);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 4;
            label5.Text = "Metodo de Pago";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(243, 122);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(50, 20);
            lblPayment.TabIndex = 5;
            lblPayment.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 578);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 6;
            label7.Text = "Total";
            // 
            // lblTotals
            // 
            lblTotals.AutoSize = true;
            lblTotals.Location = new Point(243, 578);
            lblTotals.Name = "lblTotals";
            lblTotals.Size = new Size(50, 20);
            lblTotals.TabIndex = 7;
            lblTotals.Text = "label8";
            // 
            // lvwProducts
            // 
            lvwProducts.GridLines = true;
            lvwProducts.Location = new Point(47, 182);
            lvwProducts.Name = "lvwProducts";
            lvwProducts.Size = new Size(515, 358);
            lvwProducts.TabIndex = 8;
            lvwProducts.UseCompatibleStateImageBehavior = false;
            lvwProducts.View = View.Details;
            // 
            // ReceiveView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 685);
            Controls.Add(lvwProducts);
            Controls.Add(lblTotals);
            Controls.Add(label7);
            Controls.Add(lblPayment);
            Controls.Add(label5);
            Controls.Add(lblClientName);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Name = "ReceiveView";
            Text = "ReceiveView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblDate;
        private Label label3;
        private Label lblClientName;
        private Label label5;
        private Label lblPayment;
        private Label label7;
        private Label lblTotals;
        private ListView lvwProducts;
    }
}