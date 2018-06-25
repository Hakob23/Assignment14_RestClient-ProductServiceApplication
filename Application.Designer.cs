namespace WindowsFormsRESTClient
{
    partial class Application
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Request = new System.Windows.Forms.TextBox();
            this.Response = new System.Windows.Forms.TextBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(101, 48);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(306, 20);
            this.Request.TabIndex = 0;
            this.Request.TextChanged += new System.EventHandler(this.Request_TextChanged);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(101, 85);
            this.Response.Multiline = true;
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(373, 105);
            this.Response.TabIndex = 1;
            this.Response.TextChanged += new System.EventHandler(this.Response_TextChanged);
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(444, 48);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(75, 23);
            this.buttonGO.TabIndex = 2;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 269);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.Request);
            this.Name = "Application";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Request;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.Button buttonGO;
    }
}

