namespace Event_Training_1
{

	public class Button()
    {
        public delegate void _Click(object sender, ClickEventsArgs e);//делегат
	public event _Click OnClick;// событие


	public void Click(string Name)
	{
		if (OnClick != null)
		{
			ClickEventsArgs args = new ClickEventsArgs()
			{
				NameOfButton = Name
			};
			OnClick(this, args);
		}

	}
}

}
