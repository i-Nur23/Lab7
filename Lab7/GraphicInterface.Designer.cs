
namespace Lab7
{
    partial class GraphicInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicInterface));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Create20 = new System.Windows.Forms.Button();
            this.CreateEmpty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChooseList = new System.Windows.Forms.Button();
            this.ChooseArray = new System.Windows.Forms.Button();
            this.deleteContainer = new System.Windows.Forms.Button();
            this.eraseFigs = new System.Windows.Forms.Button();
            this.showFigs = new System.Windows.Forms.Button();
            this.AddOne = new System.Windows.Forms.Button();
            this.listOfFigures = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.MoveFigs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // canvas
            // 
            resources.ApplyResources(this.canvas, "canvas");
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Name = "canvas";
            this.canvas.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Create20);
            this.panel1.Controls.Add(this.CreateEmpty);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ChooseList);
            this.panel1.Controls.Add(this.ChooseArray);
            this.panel1.Controls.Add(this.deleteContainer);
            this.panel1.Controls.Add(this.eraseFigs);
            this.panel1.Controls.Add(this.showFigs);
            this.panel1.Controls.Add(this.AddOne);
            this.panel1.Controls.Add(this.listOfFigures);
            this.panel1.Name = "panel1";
            // 
            // Create20
            // 
            resources.ApplyResources(this.Create20, "Create20");
            this.Create20.Name = "Create20";
            this.Create20.UseVisualStyleBackColor = true;
            this.Create20.Click += new System.EventHandler(this.Create20_Click);
            // 
            // CreateEmpty
            // 
            resources.ApplyResources(this.CreateEmpty, "CreateEmpty");
            this.CreateEmpty.Name = "CreateEmpty";
            this.CreateEmpty.UseVisualStyleBackColor = true;
            this.CreateEmpty.Click += new System.EventHandler(this.CreateEmpty_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ChooseList
            // 
            resources.ApplyResources(this.ChooseList, "ChooseList");
            this.ChooseList.Name = "ChooseList";
            this.ChooseList.UseVisualStyleBackColor = true;
            this.ChooseList.Click += new System.EventHandler(this.ChooseList_Click);
            // 
            // ChooseArray
            // 
            resources.ApplyResources(this.ChooseArray, "ChooseArray");
            this.ChooseArray.Name = "ChooseArray";
            this.ChooseArray.UseVisualStyleBackColor = true;
            this.ChooseArray.Click += new System.EventHandler(this.ChooseArray_Click);
            // 
            // deleteContainer
            // 
            resources.ApplyResources(this.deleteContainer, "deleteContainer");
            this.deleteContainer.Name = "deleteContainer";
            this.deleteContainer.UseVisualStyleBackColor = true;
            this.deleteContainer.Click += new System.EventHandler(this.deleteContainer_Click);
            // 
            // eraseFigs
            // 
            resources.ApplyResources(this.eraseFigs, "eraseFigs");
            this.eraseFigs.Name = "eraseFigs";
            this.eraseFigs.UseVisualStyleBackColor = true;
            this.eraseFigs.Click += new System.EventHandler(this.eraseFigs_Click);
            // 
            // showFigs
            // 
            resources.ApplyResources(this.showFigs, "showFigs");
            this.showFigs.Name = "showFigs";
            this.showFigs.UseVisualStyleBackColor = true;
            this.showFigs.Click += new System.EventHandler(this.showFigs_Click);
            // 
            // AddOne
            // 
            resources.ApplyResources(this.AddOne, "AddOne");
            this.AddOne.Name = "AddOne";
            this.AddOne.UseVisualStyleBackColor = true;
            this.AddOne.Click += new System.EventHandler(this.AddOne_Click);
            // 
            // listOfFigures
            // 
            resources.ApplyResources(this.listOfFigures, "listOfFigures");
            this.listOfFigures.FormattingEnabled = true;
            this.listOfFigures.Name = "listOfFigures";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxY);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxX);
            this.panel2.Controls.Add(this.MoveFigs);
            this.panel2.Name = "panel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxY
            // 
            resources.ApplyResources(this.textBoxY, "textBoxY");
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxX
            // 
            resources.ApplyResources(this.textBoxX, "textBoxX");
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX_KeyPress);
            // 
            // MoveFigs
            // 
            resources.ApplyResources(this.MoveFigs, "MoveFigs");
            this.MoveFigs.Name = "MoveFigs";
            this.MoveFigs.UseVisualStyleBackColor = true;
            this.MoveFigs.Click += new System.EventHandler(this.MoveFigs_Click);
            // 
            // GraphicInterface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "GraphicInterface";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listOfFigures;
        private System.Windows.Forms.Button eraseFigs;
        private System.Windows.Forms.Button showFigs;
        private System.Windows.Forms.Button AddOne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteContainer;
        private System.Windows.Forms.Button Create20;
        private System.Windows.Forms.Button CreateEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ChooseList;
        private System.Windows.Forms.Button ChooseArray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button MoveFigs;
    }
}