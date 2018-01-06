using System;
// Strategy pattern.
// Common "aspects" have been extracted into an abstract class
// The stage uses a port for communication that has to be configured during initialization.
// The communication port/device 
namespace StageCtrl
{
    public interface ICommDev
    {
        void SetPortName(string portName);
        string GetPortName();
    }
    public interface IStage
    {
        int StageId { get; set; }
        double ActualPosition { get; set; }
        double ActualVelocity { get; set; }
        double ActualAcceleration { get; set; }

        void Initialize();
        void Move();
        void Stop();
    }

    public abstract class StageBase
    {
        private readonly ICommDev _commDev;
        public int StageId { get; set; }

        public StageBase() { StageId = 0; }
        public StageBase(int Id) { StageId = Id; }
        public StageBase(int Id, ICommDev comm)
        {
            StageId = Id;
            _commDev = comm;
        }

        public abstract void Initialize();
        public abstract void Move();
        public abstract void Stop();
        public abstract double GetSetPosition();
        public abstract double GetActualPosition();
        public abstract double GetSetVelocity();
        public abstract double GetActualVelocity();
        public abstract double GetAcceleration();
        public abstract double SetSetPosition();
        public abstract double SetActualPosition();
        public abstract double SetSetVelocity();
        public abstract double SetActualVelocity();
        public abstract double SetAcceleration();
    }
}
