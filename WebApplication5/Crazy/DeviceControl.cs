using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using WebApplication5.Device;
using WebApplication5.Interfeise;

namespace WebApplication5
{
    public class DeviceControl : Panel
    {
        private int id;
        private IDictionary<int, AbstractDevice> SmartHome;

        private Button tempButton;
        private Button tempButton1;
        private Button volumeButton;
        private Button volumeButton1;
        private Button chenellButton;
        private Button chenellButton1;
        private Button onOffButton;
        private Button opencloseButton;

        private Label stateLable;
        private Label volLabel;
        private Label chenLabel;
        private Label deVLable;
        private Label inVLable;
        private Label opclLable;
        private Label boLabel;
        private Label tempInLable;
        private Label friLabel;
        private Button deleteButton;

        public DeviceControl(int id, IDictionary<int, AbstractDevice> SmartHome)
        {
            this.id = id;
            this.SmartHome = SmartHome;
            Initializer();
        }

        protected void Initializer()
        {
            CssClass = "figure-div";
            Controls.Add(Span("" + SmartHome[id] + "<br />"));
            stateLable = new Label();
            stateLable.Text = SmartHome[id].State ? "Включен" : "Выключен";
            Controls.Add(stateLable);


            onOffButton = new Button();
            onOffButton.ID = "onfi" + id.ToString();
            onOffButton.Text = "Включить/Выключить";
            onOffButton.Click += OnOffButtonClick;
            Controls.Add(onOffButton);

            Controls.Add(Span("<br />"));

            if (SmartHome[id] is IRegulatorTemp)
            {
                tempButton = new Button();
                tempButton1 = new Button();
                tempButton.ID = "temp" + id.ToString();
                tempButton.ID = "temp1" + id.ToString();
                tempButton.Text = "Увеличить температуру";
                tempButton1.Text = "Уменьшить температуру";
                tempButton.Click += TempIncrease;
                tempButton1.Click += TempDecrease;
                Controls.Add(tempButton);
                Controls.Add(tempButton1);
            }

            if (SmartHome[id] is IVolume)
            {
                volumeButton = new Button();
                volumeButton1 = new Button();
                volumeButton.ID = "votv+" + id.ToString();
                volumeButton1.ID = "votv-" + id.ToString();
                volumeButton.Text = "Увеличить громкость";
                volumeButton1.Text = "Уменьшить громкость";
                volumeButton.Click += VolumeButton;
                volumeButton1.Click += VolumeButton1;
                Controls.Add(volumeButton);
                Controls.Add(volumeButton1);
            }

            if (SmartHome[id] is IChangeChennel)
            {
                chenellButton = new Button();
                chenellButton1 = new Button();
                chenellButton.ID = "nd" + id.ToString();
                chenellButton1.ID = "pd" + id.ToString();
                chenellButton.Text = "Следующий";
                chenellButton1.Text = "Предыдущий";
                chenellButton.Click += NextChenell;
                chenellButton1.Click += PrevChenell;
                Controls.Add(volumeButton);
                Controls.Add(volumeButton1);
                Controls.Add(chenellButton);
                Controls.Add(chenellButton1);
            }

            if (SmartHome[id] is IOpenClose)
            {
                opencloseButton = new Button();
                opencloseButton.ID = "opl" + id.ToString();
                opencloseButton.Text = "Открыть";
                opencloseButton.Click += OpenCloseButton;
                Controls.Add(opencloseButton);
                //opclLable = new Label();
                //opclLable.Text = ((IOpenClose)SmartHome[id]).OpenClose ? "Oткрыто" : "Закрыто";
                //Controls.Add(stateLable);
            }


            deleteButton = new Button();
            deleteButton.ID = "hhp" + id.ToString();
            deleteButton.Text = "Удалить";
            deleteButton.Click += DeleteButtonClick;
            Controls.Add(deleteButton);
        }

        protected Label Label(bool value)
        {
            Label label = new Label();
            label.Text = value.ToString();
            return label;
        }

        protected HtmlGenericControl Span(string innerHTML)
        {
            HtmlGenericControl span = new HtmlGenericControl("span");
            span.InnerHtml = innerHTML;
            return span;
        }

        protected void DeleteButtonClick(object sender, EventArgs e)
        {
            SmartHome.Remove(id);
            Parent.Controls.Remove(this);
        }

        protected void OpenCloseButton(object sender, EventArgs e)
        {
            ((IOpenClose)SmartHome[id]).OpCl();

            //opclLable = new Label();
            //opclLable.Text = ((IOpenClose)SmartHome[id]).OpenClose ? "Oткрыто" : "Закрыто";
            //Controls.Add(stateLable);            
        }

        protected void TempDecrease(object sender, EventArgs e)
        {
            ((Temperature)SmartHome[id]).DecreaseTemp();
            //tempInLable = new Label();
            //tempInLable.Text = ((Temperature)SmartHome[id]).Temp;
            //Controls.Add(tempInLable);
        }

        protected void TempIncrease(object sender, EventArgs e)
        {
            ((Temperature)SmartHome[id]).IncreaseTemp();
        }

        protected void VolumeButton(object sender, EventArgs e)
        {
            ((IVolume)SmartHome[id]).IncreaseVolume();
            
        }
        protected void VolumeButton1(object sender, EventArgs e)
        {
            ((IVolume)SmartHome[id]).DecreaseVolume();
            //deVLable = new Label();
            //deVLable.Text = ((IVolume)SmartHome[id]).DecreaseVolume();

        }

        protected void OnOffButtonClick(object sender, EventArgs e)
        {
            SmartHome[id].OnOff();
            stateLable.Text = SmartHome[id].State ? "Включен" : "Выключен";
        }

        protected void NextChenell(object sender, EventArgs e)
        {
            ((IChangeChennel)SmartHome[id]).NextChennel();
        }
        protected void PrevChenell(object sender, EventArgs e)
        {
            ((IChangeChennel)SmartHome[id]).PreviusChennel();
        }

    }
}