# Overview

This project is a console-based cybersecurity chatbot developed in C#.
The chatbot is designed to educate users about basic cybersecurity concepts such as phishing, strong passwords, safe browsing, and online safety practices.

It interacts with users through a simple text interface, provides instant responses using keyword matching, and includes audio and visual enhancements for a better user experience.

## Features
- Interactive chatbot with continuous conversation loop
- Keyword-based question recognition
- Personalized responses using the user’s name
- Voice greeting using a .wav audio file
- Styled console interface with colors and formatting
- Typing simulation effect for realistic interaction
- Cybersecurity-focused knowledge base

## How It Works
1. User Input
The chatbot prompts the user to enter their name and ask questions.

2. Keyword Matching
Questions are not matched exactly
Instead, the program checks if the input contains certain keywords
Keywords are stored in a 2D array

3. Response Selection
Each keyword group maps to a specific answer
The chatbot searches through keywords using a loop
If a match is found, the corresponding response is returned

4. Fallback Handling
If no keyword matches:

The chatbot asks the user to rephrase their question

## Project Structure
 ### Main Method
Entry point of the application
Calls all main components:
ASCII display
Sound greeting
Chatbot interaction
 ### ASCII Class
Displays the chatbot heading using formatted console text
 ### Sound Class
Plays a .wav audio greeting using SoundPlayer
Uses PlaySync() to ensure the sound finishes before continuing
### BasicResponses Class
 Handles chatbot logic:
 1. Details()
Collects user name
Displays welcome message
 2. Response()
Runs chatbot loop
Accepts user input
Displays formatted interface
Calls response logic
 3. GetResponse()
Matches user input with keywords
Returns appropriate response
Includes fallback message if no match found

 ## Technologies Used
C#
.NET Console Application
System.Media (for audio playback)
GitHub (version control)
GitHub Actions (CI/CD)

## How to Run the Project
Open the project in Visual Studio
Ensure the .wav file is included in the project
Set:
Build Action → Content
Copy to Output Directory → Copy if newer
Build the solution
Run the programmable it 

## Example Questions You Can Ask
What is phishing?
How do I create a strong password?
Is public WiFi safe?
What is two-factor authentication?
What should I do if my password is hacked?

## Continuous Integration (CI)
This project uses GitHub Actions for CI.

### What it does:
Automatically builds the project on every push
Checks for syntax and build errors
Ensures the application runs correctly

### Workflow location:
.github/workflows/dotnet-ci.yml

### Result:
Green check = Build successful
Red X = Errors detected

## Future Improvements
Add more cybersecurity topics
Implement AI/NLP for smarter responses
Add graphical user interface (GUI)
Improve voice interaction (text-to-speech)

## Learning Outcomes
This project demonstrates:
Object-oriented programming (OOP)
Arrays and loops
User input handling
Basic AI logic (keyword recognition)
Console UI design
Audio integration in C#
CI/CD using GitHub Actions

## Author
Developed as part of a cybersecurity and programming assignment.

## Conclusion
This chatbot provides a simple but effective way to educate users about cybersecurity while demonstrating important programming concepts and real-world development practices.
