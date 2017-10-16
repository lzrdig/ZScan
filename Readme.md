# Z-Scan

Visual Studio 2017 project

A simple desktop app used to run a Z-Scan measurement. 
UI is decoupled from hardware control code.

"Moving Stage" abstract class is used the basis to create objects for different stages.

Factory pattern is used to dynamically load those objects when they are required.
Strategy pattern is used to interchange Init behaviour of a moving stage.