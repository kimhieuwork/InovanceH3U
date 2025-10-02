using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using HslCommunication.Profinet.Inovance;
using System.Diagnostics;

namespace InovanceH3U
{

    public partial class FormMain : Form
    {
        private AppSettings config;
        private bool isConnect;
        private InovanceTcpNet client; // khai báo ở cấp class để tái sử dụng sau này
        public FormMain()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            string path = "settings.json"; // or Path.Combine(Application.StartupPath, "settings.json");

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                config = JsonConvert.DeserializeObject<AppSettings>(json);

                // present to textbox form
                //txtPlcIp.Text = config.PLC.IP;
                //txtPlcPort.Text = config.PLC.Port.ToString();
                //cboComPort.Text = config.COM.PortName;
            }
            else
            {
                MessageBox.Show("Không tìm thấy file settings.json");
            }
        }

        private void SwitchPLC_OnSwitchChanged(object arg1, bool arg2)
        {

        }

        private async void btnConnectPLC_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Dang ket noi. ... ";
            btnConnectPLC.Enabled = false;
            try
            {
                var result = await Task.Run(() =>
                {
                    client = new InovanceTcpNet(config.PLC.IP, config.PLC.Port);
                    client.ConnectTimeOut = 3000; // 3 giây

                    return client.ConnectServer(); // trả về OperateResult
                });

                if (result.IsSuccess)
                {
                    lblStatus.Text = "✅ Kết nối thành công!";
                }
                else
                {
                    lblStatus.Text = "❌ Kết nối thất bại: " + result.Message;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Ket noi that bai !" + ex.Message;
                //MessageBox.Show("There is no connection !!!:" + ex.Message, "PLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConnectPLC.Enabled = true;
            }
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string folderPath = @"D:\MyImages"; // ví dụ thư mục ảnh

            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Folder không tồn tại!");
            }
        }
    }
}
