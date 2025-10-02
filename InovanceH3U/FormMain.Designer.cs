
namespace InovanceH3U
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.hslMoveText1 = new HslControls.HslMoveText();
            this.SwitchPLC = new HslControls.HslSwitch();
            this.btnOpenLog = new HslControls.HslButton();
            this.btnReload = new HslControls.HslButton();
            this.btnConnectPLC = new HslControls.HslButton();
            this.lblStatus = new HslControls.HslLabel();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.hslClock1 = new HslControls.HslClock();
            this.hslLedDisplay1 = new HslControls.HslLedDisplay();
            this.btnOpenFolder = new HslControls.HslButton();
            this.SuspendLayout();
            // 
            // hslMoveText1
            // 
            this.hslMoveText1.BackColor = System.Drawing.Color.Gray;
            this.hslMoveText1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hslMoveText1.ForeColor = System.Drawing.Color.Yellow;
            this.hslMoveText1.Location = new System.Drawing.Point(0, 0);
            this.hslMoveText1.MoveSpeed = 10F;
            this.hslMoveText1.Name = "hslMoveText1";
            this.hslMoveText1.Size = new System.Drawing.Size(1077, 41);
            this.hslMoveText1.TabIndex = 0;
            this.hslMoveText1.Text = "InovanceH3U asdfasdfkllk;sdjfak;sdklfjalkdsjklf;aj;sdj;fjads;jkfjklasjl;djfkajdjl" +
    "k;f;lkask;jfads";
            // 
            // SwitchPLC
            // 
            this.SwitchPLC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchPLC.Location = new System.Drawing.Point(843, 66);
            this.SwitchPLC.Name = "SwitchPLC";
            this.SwitchPLC.Size = new System.Drawing.Size(150, 150);
            this.SwitchPLC.SwitchForeground = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.SwitchPLC.TabIndex = 1;
            this.SwitchPLC.Text = "PLC";
            this.SwitchPLC.OnSwitchChanged += new System.Action<object, bool>(this.SwitchPLC_OnSwitchChanged);
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.CustomerInformation = null;
            this.btnOpenLog.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenLog.Location = new System.Drawing.Point(879, 265);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(114, 46);
            this.btnOpenLog.TabIndex = 2;
            this.btnOpenLog.Text = "Open LOG";
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // btnReload
            // 
            this.btnReload.CustomerInformation = null;
            this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReload.Location = new System.Drawing.Point(879, 342);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(114, 46);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            // 
            // btnConnectPLC
            // 
            this.btnConnectPLC.CustomerInformation = null;
            this.btnConnectPLC.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnectPLC.Location = new System.Drawing.Point(879, 419);
            this.btnConnectPLC.Name = "btnConnectPLC";
            this.btnConnectPLC.Size = new System.Drawing.Size(114, 46);
            this.btnConnectPLC.TabIndex = 5;
            this.btnConnectPLC.Text = "Connect PLC";
            this.btnConnectPLC.Click += new System.EventHandler(this.btnConnectPLC_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(876, 489);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(60, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(73, 269);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(718, 199);
            this.lstLog.TabIndex = 7;
            // 
            // hslClock1
            // 
            this.hslClock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hslClock1.BackgroundImage")));
            this.hslClock1.IsShowCalendar = false;
            this.hslClock1.Location = new System.Drawing.Point(73, 47);
            this.hslClock1.Name = "hslClock1";
            this.hslClock1.Size = new System.Drawing.Size(182, 179);
            this.hslClock1.TabIndex = 8;
            this.hslClock1.Text = "hslClock1";
            // 
            // hslLedDisplay1
            // 
            this.hslLedDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.hslLedDisplay1.DisplayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.hslLedDisplay1.Location = new System.Drawing.Point(466, 94);
            this.hslLedDisplay1.Name = "hslLedDisplay1";
            this.hslLedDisplay1.Size = new System.Drawing.Size(325, 58);
            this.hslLedDisplay1.TabIndex = 9;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.CustomerInformation = null;
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenFolder.Location = new System.Drawing.Point(73, 474);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(114, 46);
            this.btnOpenFolder.TabIndex = 10;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 577);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.hslLedDisplay1);
            this.Controls.Add(this.hslClock1);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnectPLC);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.SwitchPLC);
            this.Controls.Add(this.hslMoveText1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HslControls.HslMoveText hslMoveText1;
        private HslControls.HslSwitch SwitchPLC;
        private HslControls.HslButton btnOpenLog;
        private HslControls.HslButton btnReload;
        private HslControls.HslButton btnConnectPLC;
        private HslControls.HslLabel lblStatus;
        private System.Windows.Forms.ListBox lstLog;
        private HslControls.HslClock hslClock1;
        private HslControls.HslLedDisplay hslLedDisplay1;
        private HslControls.HslButton btnOpenFolder;
    }
}

