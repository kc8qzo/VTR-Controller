using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerButtonControl
{
    public partial class PowerButton : UserControl
    {
        private bool powerOnState;

        private void changeState(bool state)
        {
            if (state)
            {
                this.BackgroundImage = Properties.Resources.Power_Button_On;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Power_Button_Off;
            }

            if (this.PowerStateChanged != null)
            {
                object obj = new object();
                obj = powerOnState;
                this.PowerStateChanged(obj, new EventArgs());
            }


        }

        #region Public Methods

        public event EventHandler PowerStateChanged;

        public PowerButton()
        {
            InitializeComponent();
        }

        public bool PowerOnState
        {
            get { return powerOnState; }
            set
            {
                powerOnState = value;
                changeState(value);
            }
        }
        public void ToggleState()
        {
            if (powerOnState)
            {
                powerOnState = false;
            }
            else
            {
                powerOnState = true;
            }
            changeState(powerOnState);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ToggleState();
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ToggleState();
            }
        }


        #endregion






    }
}
