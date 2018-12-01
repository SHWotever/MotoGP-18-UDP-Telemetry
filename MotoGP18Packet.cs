using System;
using System.Runtime.InteropServices;

namespace MotoGP18UDPTelemetry
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MotoGP18Packet
    {
        [FieldOffset(0)]
        public Int32 Header;

        [FieldOffset(4)]
        public UInt32 packetid;

        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string Track;

        [FieldOffset(40)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string Model;

        [FieldOffset(104)]
        public byte CurrentLap;

        [FieldOffset(105)]
        public byte Position;

        [FieldOffset(106)]
        public Single LapTime;

        [FieldOffset(110)]
        public Single LastLapTime;

        [FieldOffset(114)]
        public Single SessionTime;

        [FieldOffset(118)]
        public byte GameMode;

        [FieldOffset(119)]
        public Single S1;

        [FieldOffset(123)]
        public Single S2;

        [FieldOffset(127)]
        public Single S3;

        [FieldOffset(136)]
        public Single LapDistance;

        [FieldOffset(140)]
        public Single TotalDistance;

        [FieldOffset(150)]
        public Single CoordinatesX;

        [FieldOffset(154)]
        public Single CoordinatesY;

        [FieldOffset(158)]
        public Single CoordinatesZ;

        //        [FieldOffset(162)]
        //        public Single?;

        //[FieldOffset(166)]
        //        public Single?;

        [FieldOffset(170)]
        public Single Pitch;

        [FieldOffset(174)]
        public Single Yaw;

        [FieldOffset(187)]
        public Single MaxRpm;

        [FieldOffset(191)]
        public byte gear;

        [FieldOffset(192)]
        public Single RPM;

        [FieldOffset(196)]
        public Single Steering;

        [FieldOffset(200)]
        public Single Throttle;

        [FieldOffset(204)]
        public Single Clutch;

        [FieldOffset(208)]
        public Single BrakeF;

        [FieldOffset(212)]
        public Single BrakeR;

        [FieldOffset(216)]
        public Single SuspensionPositionF;

        [FieldOffset(220)]
        public Single SuspensionPositionR;

        [FieldOffset(232)]
        public Single WheelSpeedF;

        [FieldOffset(236)]
        public Single WheelSpeedR;

        [FieldOffset(250)]
        public Single WheelSlipF;

        [FieldOffset(254)]
        public Single WheelSlipR;

        [FieldOffset(266)]
        public byte FrontTyreCompound;

        [FieldOffset(267)]
        public byte RearTyreCompound;

        [FieldOffset(268)]
        public Single BrakeTempF;

        [FieldOffset(276)]
        public Single LongitudinalBodyPosition;

        [FieldOffset(284)]
        public Single LateralGforce;

        [FieldOffset(288)]
        public Single LongitudinalGforce;

        [FieldOffset(292)]
        public Single Speed;

        public string FrontTyreCompoundName { get { return ((Compound)FrontTyreCompound).ToString(); } }
        public string RearTyreCompoundName { get { return ((Compound)FrontTyreCompound).ToString(); } }
    }

    public enum Compound
    {
        Soft = 2,
        Medium = 4,
        Hard = 6
    }
}