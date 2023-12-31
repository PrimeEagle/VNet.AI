﻿namespace VNet.AI.Behavior
{
    public enum SourceCategory
    {
        Internal,
        External
    }

    public enum ModalityType
    {
        None,
        Light,
        Sound,
        Taste,
        Smell,
        Touch,
        Pain,
        Thermoception,
        Mechanoreception,
        Interoception
    }

    public enum ModalitySubtype
    {
        None,
        LightAll,
        LightIntensity,
        LightColor,
        LightColorRed,
        LightColorGreen,
        LightColorBlue,
        SoundAll,
        SoundVibration,
        SoundFrequency,
        SmellAll,
        TasteAll,
        TasteSweet,
        TasteSalty,
        TasteSour,
        TasteBitter,
        TasteUmami,
        TouchAll,
        TouchPresure,
        TouchLightTouch,
        PainAll,
        PainVisceral,
        PainSomatic,
        PainNeuropathic,
        ThermoceptionAll,
        ThermoceptionHeat,
        ThermoceptionCold,
        MechanoreceptionAll,
        MechanoreceptionAccelerationRotational,
        MechanoreceptionAccelerationLinear,
        MechanoreceptionProprioception,
        MechanoreceptionKinesthesis,
        MechanoreceptionMuscleTension,
        MechanoreceptionMuscleLengtheningRate,
        InteroceptionAll,
        InteroceptionBloodPressure,
        InteroceptionBloodPressureArterial,
        InteroceptionBloodPressureCentralNervous,
        InteroceptionBloodPressureHead,
        InteroceptionBloodOxygen,
        InteroceptionCerebrospinalFluidpH,
        InteroceptionThirst,
        InteroceptionHunger,
        InteroceptionLungInflation,
        InteroceptionBladderStretch,
        InteroceptionFullStomach
    }
}
