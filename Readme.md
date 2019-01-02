# Z-Scan

Visual Studio 2017 project

A simple desktop app used to run a Z-Scan measurement. 
UI is decoupled from hardware control code.

"Moving Stage" abstract class is used as the basis to create objects for different stages.

Factory pattern is used to dynamically load those objects when they are required.
Strategy pattern is used to interchange Init behaviour of a moving stage.
Only Linear moving stages are considered in the "abstraction". This implies here that one-axis stages are included only. Even though combos can be created, they are not part of a Z-scan application.
