﻿namespace ZWave.Channel
{
    public enum CommandClass : byte
    {
        NoOperation = 0x00,
        ZWave = 0x01,
        ZWaveLR = 0x04,
        Basic = 0x20,
        ApplicationStatus = 0x22,
        SwitchBinary = 0x25,
        SwitchMultiLevel = 0x26,
        ToggleBinary = 0x28,
        ToggleMultiLevel = 0x29,
        SceneActivation = 0x2B,
        ActuatorConf = 0x2C,
        ControllerConf = 0x2D,
        SensorBinary = 0x30,
        SensorMultiLevel = 0x31,
        Meter = 0x32,
        Color = 0x33,
        MeterPulse = 0x35,
        HrvStatus = 0x37,
        HrvControl = 0x39,
        MeterTableMonitor = 0x3D,
        ThermostatMode = 0x40,
        ThermostatOperatingState = 0x42,
        ThermostatSetpoint = 0x43,
        ThermostatFanMode = 0x44,
        ThermostatFanState = 0x45,
        ClimateControlSchedule = 0x46,
        ThermostatSetback = 0x47,
        DoorLockLogging = 0x4C,
        ScheduleEntryLock = 0x4E,
        Schedule = 0x53,
        CRC16Encap = 0x56,
        AssociationGroupInformation = 0x59,
        DeviceResetLocally = 0x5A,
        CentralScene = 0x5B,
        AntiTheft = 0x5D,
        ZWavePlusInfo = 0x5E,
        MultiChannel = 0x60,
        DoorLock = 0x62,
        UserCode = 0x63,
        HumidityControlSetpoint = 0x64,
        BarrierOperator = 0x66,
        WindowCovering = 0x6A,
        Supervision = 0x6C,
        HumidityControlMode = 0x6D,
        HumidityControlOperatingState = 0x6E,
        EntryControl = 0x6F,
        Configuration = 0x70,
        Alarm = 0x71,
        Notification = 0x71,
        ManufacturerSpecific = 0x72,
        PowerLevel = 0x73,
        InclusionController = 0x74,
        Protection = 0x75,
        NodeNaming = 0x77,
        SoundSwitch = 0x79,
        FirmwareUpdateMD = 0x7A,
        Battery = 0x80,
        Clock = 0x81,
        Hail = 0x82,
        WakeUp = 0x84,
        Association = 0x85,
        Version = 0x86,
        Indicator = 0x87,
        Proprietary = 0x88,
        Language = 0x89,
        Time = 0x8A,
        TimeParams = 0x8B,
        MultiChannelAssociation = 0x8E,
        MultiCommand = 0x8F,
        SimpleAVControl = 0x94,
        Security = 0x98,
        SensorAlarm = 0x9C,
        SilenceAlarm = 0x9D,
        SensorConfiguration = 0x9E,
        Security2 = 0x9F
    }
}