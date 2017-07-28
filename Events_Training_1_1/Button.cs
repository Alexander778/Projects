using System;
namespace Events_Training_1_1
{

    public class Button
    {
        public delegate void ClickButton(object sender, ClickEventsArgs e);
        public event ClickButton OnClick;




        public void ClickOnTheButton(string Name)
        {
            if (OnClick != null)
            {
                ClickEventsArgs args = new ClickEventsArgs();
                {
                    NameOfButton = Name;
                };
                OnClick(this, args);
            }
        }

    }
}
