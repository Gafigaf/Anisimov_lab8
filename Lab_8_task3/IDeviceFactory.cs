namespace Lab_8_task3
{
    public interface IDeviceFactory
    {
        IScreen CreateScreen();
        IProcessor CreateProcessor();
        ICamera CreateCamera();
    }
}