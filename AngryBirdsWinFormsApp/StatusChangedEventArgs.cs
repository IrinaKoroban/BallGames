namespace AngryBirdsWinFormsApp
{
    public class StatusChangedEventArgs : EventArgs
    {
        public Status Status;

        public StatusChangedEventArgs(Status status)
        {
            Status = status;
        }
    }
}

