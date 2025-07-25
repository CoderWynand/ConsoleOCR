# Console OCR ReadMe

### Introduction

I chose this project to learn about neural networks and how they are able to perform Optical Character Recognition (OCR). This project also serves a practical use case of converting university material (e.g. slides) to a text format.

### Program Overview

##### Program.cs

This is a simple Optical Character Recognition console application built with C# using the Tesseract OCR library. It allows the user to extract text from an image in one of several supported languages.



Allows a user to select a language, from the following list:

* English
* French
* Hindi
* Simplified Mandarin
* Traditional Mandarin
* Spanish



Accepts a user specified path to the image, then extracts and prints the recognized text from the image. Includes error handling for missing files and Tesseract processing issues.

##### OCR Processor.cs

This class contains the code that creates the engine and processes the text, then returns the output to the main class.



### Running the program

Please ensure that the following dependencies are present on your system:



1. .NET DSK 6.0 or higher
2. Tesseract OCR
3. Appropriate tessdata folder with trained files



Then clone/download the project, navigate to project directory, then build and run using "dotnet build" and "dotnet run" respectively.

### Known issues/Future improvements:

1. **Lack of a GUI:** The project currently lacks a GUI, which reduces user friendliness. Future additions could look at adding one.
2. **Limited cities:** Currently, weather data can only be retrieved from a limited amount of cities.
3. **More detailed error handling:** Further steps can be added to handle errors more thoroughly.
