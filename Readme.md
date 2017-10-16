# Z-Scan

Visual Studio 2017 project

A simple desktop app used to run a Z-Scan measurement. UI decoupled from hardware control module.

Moving stage abstract class used to create object for different stages.
Factory pattern is used to dynamically load those object when they are required.
Strategy pattern used to interchange Init behaviour of moving stage.