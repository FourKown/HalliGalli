
namespace HalliGalli
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Bell_Button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::HalliGalli.Properties.Resources.Back_card;
            this.label1.Location = new System.Drawing.Point(410, 832);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 400);
            this.label1.TabIndex = 1;
            // 
            // Bell_Button
            // 
            this.Bell_Button.BackColor = System.Drawing.Color.Chartreuse;
            this.Bell_Button.BackgroundImage = global::HalliGalli.Properties.Resources.bell;
            this.Bell_Button.Location = new System.Drawing.Point(563, 478);
            this.Bell_Button.Name = "Bell_Button";
            this.Bell_Button.Size = new System.Drawing.Size(350, 300);
            this.Bell_Button.TabIndex = 0;
            this.Bell_Button.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Apple1.png");
            this.imageList1.Images.SetKeyName(1, "Apple2.png");
            this.imageList1.Images.SetKeyName(2, "Apple3.png");
            this.imageList1.Images.SetKeyName(3, "Apple4.png");
            this.imageList1.Images.SetKeyName(4, "Apple5.png");
            this.imageList1.Images.SetKeyName(5, "Banana1.png");
            this.imageList1.Images.SetKeyName(6, "Banana2.png");
            this.imageList1.Images.SetKeyName(7, "Banana3.png");
            this.imageList1.Images.SetKeyName(8, "Banana4.png");
            this.imageList1.Images.SetKeyName(9, "Banana5.png");
            this.imageList1.Images.SetKeyName(10, "grape1.png");
            this.imageList1.Images.SetKeyName(11, "grape2.png");
            this.imageList1.Images.SetKeyName(12, "grape3.png");
            this.imageList1.Images.SetKeyName(13, "grape4.png");
            this.imageList1.Images.SetKeyName(14, "grape5.png");
            this.imageList1.Images.SetKeyName(15, "watermellon1.png");
            this.imageList1.Images.SetKeyName(16, "watermellon2.png");
            this.imageList1.Images.SetKeyName(17, "watermellon3.png");
            this.imageList1.Images.SetKeyName(18, "watermellon4.png");
            this.imageList1.Images.SetKeyName(19, "watermellon5.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 1261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bell_Button);
            this.Name = "Form1";
            this.Text = "Halli Galli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bell_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

