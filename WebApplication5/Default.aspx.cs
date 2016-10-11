using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication5.Device;

namespace WebApplication5
{
    public partial class Default : System.Web.UI.Page
    {
        protected IDictionary<int, AbstractDevice> SmartHome;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SmartHome = (SortedDictionary<int, AbstractDevice>)Session["Device"];
                //ErrorChannel.Text = "";
                //ErrorVolume.Text = "";
            }

            else
            {
                SmartHome = new SortedDictionary<int, AbstractDevice>();
                SmartHome.Add(1, new TV(false, 100, 50));
                SmartHome.Add(2, new MusikCentre(false, 100, 50));
                SmartHome.Add(3, new Boiler(false, 90, 10, 15));
                SmartHome.Add(4, new Conditioner(false, 40, 10, 18));
                SmartHome.Add(5, new Fridge(false, 20, -18, 0, false));
                Session["Device"] = SmartHome;
                Session["NextId"] = 9;

            }
            InitialiseDevicePanel();

        }

        protected void InitialiseDevicePanel()
        {
            foreach (int key in SmartHome.Keys)
            {
                newPanel.Controls.Add(new DeviceControl(key, SmartHome));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AbstractDevice newDevice;

            switch (((Button)sender).ID)
            {
                case "Button1":
                    newDevice = new TV(false, 100, 50);
                    break;
                case "Button2":
                    newDevice = new MusikCentre(false, 100, 50);
                    break;
                case "Button3":
                    newDevice = new Conditioner(false, 40, 10, 18);
                    break;
                case "Button4":
                    newDevice = new Boiler(false, 90, 10, 15);
                    break;
                default:
                    newDevice = new Fridge(false, 20, -18, 0, false);
                    break;
            }

            int id = (int)Session["NextId"];
            SmartHome.Add(id, newDevice); // Добавление фигуры в коллекцию
            newPanel.Controls.Add(new DeviceControl(id++, SmartHome)); // Добавление графики для фигуры
            id++;
            Session["NextId"] = id;
        }
    }
}