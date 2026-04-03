using System;

class SynapseEMFCalculator
{
    // Constants
    const double MembraneCapacitancePerArea = 1e-2; // F/m² (1 µF/cm²)
    const double SynapseArea = 1e-12; // m² (~1 µm² synapse)
    const double MembraneThickness = 5e-9; // meters (5 nm)

    static void Main()
    {
        Console.WriteLine("=== Synapse EMF Calculator ===\n");

        // Target voltage change (e.g., depolarization)
        double targetVoltage = 0.1; // volts (100 mV typical)

        // Calculate capacitance
        double capacitance = MembraneCapacitancePerArea * SynapseArea;

        // Calculate charge
        double charge = capacitance * targetVoltage;

        // Electric field across membrane
        double electricField = targetVoltage / MembraneThickness;

        Console.WriteLine($"Synapse Area: {SynapseArea} m²");
        Console.WriteLine($"Capacitance: {capacitance:E} F");
        Console.WriteLine($"Target Voltage: {targetVoltage} V");

        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Required Charge: {charge:E} C");
        Console.WriteLine($"Equivalent EMF: {targetVoltage} V");
        Console.WriteLine($"Electric Field Strength: {electricField:E} V/m");

        // Optional: external field estimation (very rough)
        double couplingEfficiency = 1e-6; // biological shielding factor
        double requiredExternalField = electricField / couplingEfficiency;

        Console.WriteLine("\n--- External Field Estimate ---");
        Console.WriteLine($"Approx External Field Needed: {requiredExternalField:E} V/m");

        Console.WriteLine("\n(Note: External field is vastly higher due to shielding)");
    }
}
