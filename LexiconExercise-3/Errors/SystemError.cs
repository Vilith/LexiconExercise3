namespace LexiconExercise_3.Errors
{
    public abstract class SystemError
    {
        public abstract string ErrorMessage();
    }

    public class EngineFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Engine alert: Check engine status!";
        }
    }

    public class BrakeFailureError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Brake alert: Unsafe to drive. Contact nearest mechanic!";
        }
    }

    public class TransmissionError : SystemError
    {
        public override string ErrorMessage()
        {
            return "Transmission alert: Contact nearest mechanic!";
        }
    }
}
