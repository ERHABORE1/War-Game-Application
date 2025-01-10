War Game Application

Overview

The War Game Application is a card-based game built using .NET and Blazor. This application simulates the classic "War" card game, allowing players to draw, play, and compete in rounds of strategic card battles. It showcases a robust implementation of game logic, interactive UI, and efficient use of Blazor components.

Features

Card Management: Shuffle, deal, and play cards dynamically.

Player Hands: Track individual player hands and played cards.

Game Logic: Implement rounds of card comparisons to determine winners.

Responsive Design: A user-friendly interface built with Blazor and Bootstrap.

Tech Stack

Frontend: Blazor (Razor Components)

Backend: .NET Core

Styling: Bootstrap, custom CSS

Development Environment: Visual Studio

Project Structure

├── App.razor                         # Root component of the application
├── Data/
│   ├── Card.cs                       # Represents a card in the deck
│   ├── Deck.cs                       # Logic for the deck of cards
│   ├── Hand.cs                       # Represents a player's hand
│   ├── PlayedCards.cs                # Tracks played cards
│   ├── PlayerHands.cs                # Manages player hands
├── Pages/
│   ├── Game.razor                    # Main game page
│   ├── PlayerHand.razor              # Displays player hand details
│   ├── Index.razor                   # Homepage
├── Services/
│   ├── CardWarService.cs             # Game logic implementation
│   ├── ICardWarService.cs            # Interface for game services
├── Shared/
│   ├── MainLayout.razor              # Main layout component
│   ├── NavMenu.razor                 # Navigation menu
├── wwwroot/
│   ├── css/                          # Static CSS files
│   ├── favicon.ico                   # Favicon for the application
├── appsettings.json                  # Application configuration
├── Program.cs                        # Application entry point
└── War_Game_App.sln                  # Visual Studio solution file

Getting Started

Prerequisites

Visual Studio 2022 or later

.NET Core SDK

Installation

Clone the repository:

git clone https://github.com/ERHABORE1/War-Game-App.git

Open the solution file (War_Game_App.sln) in Visual Studio.

Restore dependencies:

dotnet restore

Run the application:

dotnet run

Gameplay Instructions

Navigate to the game page.

Use the interface to shuffle, deal, and play cards.

Follow on-screen instructions to compete and win rounds.

Screenshots

Home Page

![Screenshot (104)](https://github.com/user-attachments/assets/d898fa4f-56fd-4f5d-8aa3-e7c004451a45)


Game Page
![Screenshot (105)](https://github.com/user-attachments/assets/ddc34ede-a843-4d47-8dd4-b37947a15618)



Contributing

Contributions are welcome! Please follow these steps:

Fork the repository.

Create a new branch: git checkout -b feature/your-feature.

Commit your changes: git commit -m 'Add some feature'.

Push to the branch: git push origin feature/your-feature.

Open a pull request.

License

This project is licensed under the MIT License. See the LICENSE file for details.

Contact

For any questions or feedback, feel free to reach out at erhabore1@etsu.edu.
