namespace DomainModel.Config
{
    public class DbOperationManager
    {
        public static bool AllowCascadeDeleting { get; private set; } = false;

        public static void SwitchCascadeDeletingOption()
        {
            AllowCascadeDeleting = !AllowCascadeDeleting;
        }
    }
}
