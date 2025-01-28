namespace CSharpEgitimKampi601
{
    partial class FrmCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerShoppingCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(363, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 476);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(155, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(155, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(155, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(155, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerShoppingCount
            // 
            this.txtCustomerShoppingCount.Location = new System.Drawing.Point(174, 218);
            this.txtCustomerShoppingCount.Name = "txtCustomerShoppingCount";
            this.txtCustomerShoppingCount.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerShoppingCount.TabIndex = 28;
            this.txtCustomerShoppingCount.TextChanged += new System.EventHandler(this.txtCustomerShoppingCount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(20, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aleşveriş Tutarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCustomerBalance
            // 
            this.txtCustomerBalance.Location = new System.Drawing.Point(174, 182);
            this.txtCustomerBalance.Name = "txtCustomerBalance";
            this.txtCustomerBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerBalance.TabIndex = 26;
            this.txtCustomerBalance.TextChanged += new System.EventHandler(this.txtCustomerBalance_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(87, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bakiye";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(174, 74);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerName.TabIndex = 24;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(52, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Müsteri Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(174, 110);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerSurname.TabIndex = 22;
            this.txtCustomerSurname.TextChanged += new System.EventHandler(this.txtCustomerSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Müsteri Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(174, 146);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerCity.TabIndex = 20;
            this.txtCustomerCity.TextChanged += new System.EventHandler(this.txtCustomerCity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(37, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Müsteri Şehir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(174, 38);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerId.TabIndex = 18;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Müsteri Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerShoppingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerShoppingCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
    }
}