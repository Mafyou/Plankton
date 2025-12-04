# 🐋 Plankton Game
*A whale met a plankton. Imagine the REST.*

## 📖 What is Plankton Game?

**Plankton Game** is an interactive racing simulation where you, as a hungry whale, send encrypted plankton into a feeding frenzy! Watch as different types of plankton (Little 🔵, Big 🟢, and Average 🟡) compete in real-time races through encrypted API calls. The fastest plankton to be "consumed" wins!

Built with .NET 10, this game demonstrates advanced asynchronous programming, concurrent API calls, and cryptographic operations in a fun and visual way.

---

## 🎮 How The Game Works

### **The 3-Step Game Flow**

```
┌─────────────────────────────────────────────────────────────────┐
│  STEP 1: CONFIGURE YOUR API ENDPOINT                            │
│  ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━                           │
│  🌐 Set the race server address (where races happen)            │
│  Default: https://planktonapi.azurewebsites.net                 │
│  💡 Use the "Use Default" button for quick reset               │
└─────────────────────────────────────────────────────────────────┘
                              ↓
┌─────────────────────────────────────────────────────────────────┐
│  STEP 2: CONFIGURE & SEND ENCRYPTED PLANKTONS TO RACE           │
│  ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━ │
│  🔢 Choose how many planktons to race                           │
│     • Type manually (e.g., 10, 50, 100)                         │
│     • Or use quick-select buttons: [5] [10] [50]                │
│  🔐 Each plankton type (Little, Big, Average) is encrypted      │
│      and sent to the API in a race condition                    │
│  ⚡ Multiple API calls happen simultaneously                     │
│  🚀 Click "Ready ?" to start the race!                          │
└─────────────────────────────────────────────────────────────────┘
                              ↓
┌─────────────────────────────────────────────────────────────────┐
│  STEP 3: VIEW THE DECRYPTED RESULTS & RANKINGS                  │
│  ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━                   │
│  🏆 See which plankton type won each position                   │
│  🥇🥈🥉 Gold, silver, bronze badges for top 3                  │
│  📊 View the leaderboard with plankton counts                   │
│  🎯 Fastest API responses = Higher rankings                     │
│  🎨 Color-coded plankton types with emojis                      │
└─────────────────────────────────────────────────────────────────┘
```

### **Visual Example**

**What You See:**
```
╔════════════════════════════════════════╗
║  🐋 Feed the Whale!                   ║
║  Send encrypted planktons into an     ║
║  epic race!                           ║
╠════════════════════════════════════════╣
║  🌐 API Endpoint                      ║
║  [planktonapi.azurewebsites.net]     ║
║  [Use Default]                        ║
╠════════════════════════════════════════╣
║  🎯 Race Configuration                ║
║  How many planktons to race?          ║
║  [10]                                 ║
║  [5]  [10]  [50]  ← Quick select     ║
║                                        ║
║  [🚀 Ready ?]                         ║
╚════════════════════════════════════════╝

         ↓ Click "Ready ?" ↓

╔════════════════════════════════════════╗
║  🏆 Race Leaderboard                  ║
╠════════════════════════════════════════╣
║  🥇 #1  🟢 Big        [4 🦠]         ║
║  🥈 #2  🔵 Little     [3 🦠]         ║
║  🥉 #3  🟡 Average    [3 🦠]         ║
║  🔵 #4  🔵 Little     [2 🦠]         ║
║  ...                                   ║
╠════════════════════════════════════════╣
║  💡 How It Works                      ║
║  Each plankton type races             ║
║  simultaneously using encrypted API    ║
║  calls. The fastest responses win! ⚡  ║
╚════════════════════════════════════════╝
```

---

## ✨ Key Features

### 🎯 **User-Friendly Interface**
- **Ocean-Themed Design**: Beautiful blue gradient with underwater vibes 🌊
- **Configurable API Endpoint**: Change the race server address on the fly
- **Quick-Select Buttons**: Fast setup with [5], [10], [50] buttons
- **Simple Setup**: Just enter the number of planktons and click start
- **Real-Time Updates**: Watch the race results appear as they complete
- **Visual Leaderboard**: Clear rankings showing which plankton type is winning
- **Medal Badges**: Gold 🥇, Silver 🥈, Bronze 🥉 for top 3 positions
- **Emoji Indicators**: Color-coded plankton types (🔵 🟢 🟡)
- **Cross-Platform**: Works on Windows, macOS, iOS, and Android

### 🔒 **Behind the Scenes Security**
- All plankton data is **encrypted** before sending to the API
- Results are **decrypted** automatically for display
- Secure **AES-256 encryption** protects the race data
- **Input validation** for API endpoints and race counts

### 🏁 **Real Race Conditions**
- Multiple plankton types race **simultaneously**
- Fastest API response wins the position
- Demonstrates real-world **concurrent programming**
- **Thread-safe** result aggregation

### 🎨 **Modern UI/UX Design**
- **Card-based layout** with rounded corners and shadows
- **Responsive design** adapts to different screen sizes
- **Accessibility support** with semantic descriptions
- **No Frame controls** - Uses modern Border elements exclusively
- **Smooth interactions** with visual feedback

---

## 🚀 Quick Start Guide

### Prerequisites
- **.NET 10 SDK** ([Download here](https://dotnet.microsoft.com/download))
- **Visual Studio 2026** or **Visual Studio Code**
- For mobile: **Xcode** (iOS) or **Android SDK** (Android)

### 🎮 Play the Game (5 Minutes Setup)

1. **Clone & Restore**
   ```bash
   git clone https://github.com/Mafyou/Plankton
   cd Plankton
   dotnet restore
   ```

2. **Run the Game**
   ```bash
   cd src/Front/Whale.Maui
   dotnet run --framework net10.0-windows  # Windows
   # Or open Whale.Maui.csproj in Visual Studio and press F5
   ```

3. **Start Racing!**
   - The app launches with the default Azure API endpoint
   - (Optional) Change the API endpoint if you're running your own server
   - Enter your desired number of races (e.g., 10) or use quick-select buttons
   - Click **"Ready ?"** to start
   - Watch the leaderboard populate with results in real-time!

### 🎯 Pro Tips for Players

- **Start Small**: Try 5-10 races first to see how it works
- **Use Quick-Select**: The [5], [10], [50] buttons make setup instant
- **Go Big**: Increase to 50-100 races for dramatic competitions
- **Watch the Rankings**: Different runs may produce different winners due to race conditions
- **API Endpoint**: Default hosted endpoint works out of the box—no setup needed!
- **Custom Endpoint**: Point to `localhost` if you're running the API locally
- **Medal Hunt**: Try to get your favorite plankton type to win the gold medal! 🥇

---

## 🏗️ Technical Architecture

<details>
<summary><b>Click to expand architecture details</b></summary>

### Project Components

#### 📱 **Whale.Maui** - The Game Interface
- Cross-platform .NET MAUI application
- MVVM pattern with CommunityToolkit.Mvvm
- Real-time UI updates during races
- Modern Border-based UI (no legacy Frame controls)
- Value converters for emoji and color mapping
- Supports iOS, Android, macOS, and Windows

#### 🌐 **Plankton.API** - The Race Server
- ASP.NET Core minimal API
- Hosted on Azure: `planktonapi.azurewebsites.net`
- Handles encrypted race requests
- Returns decrypted race results

#### 🔐 **Plankton.CryptoHelper** - Security Layer
- AES encryption/decryption utilities
- Ensures secure data transmission
- Base64 encoding for transport
- Shared encryption key: `E546C8DF278CD5931069B522E695D4F2`

#### 🏁 **Plankton.RaceHelper** - Race Engine
- Manages concurrent task racing
- Thread-safe result aggregation
- Dynamic scheduling and coordination
- Race condition management

#### 📦 **Plankton.DTO** - Data Models
- Shared contracts between client and server
- Encrypted and decrypted data structures
- Type-safe communication

### The Race Flow (Technical)

```
1. User Configuration (Whale.Maui)
   └─> Set API endpoint (optional)
   └─> Choose number of races (e.g., 10)

2. Encryption (CryptoHelper)
   └─> Encrypt each plankton type + count
       ├─> "Little" + 10 → [AES encrypted]
       ├─> "Big" + 10    → [AES encrypted]
       └─> "Average" + 10 → [AES encrypted]

3. Concurrent Racing (RaceHelper)
   └─> Send all encrypted requests simultaneously
       ├─> POST /race [encrypted Little]  ⚡
       ├─> POST /race [encrypted Big]     ⚡
       └─> POST /race [encrypted Average] ⚡
       (3 requests per race count = 30 total for 10 races)

4. API Processing (Plankton.API)
   └─> Decrypt → Process → Return results
       ├─> {kind: "Big", count: 10}
       ├─> {kind: "Little", count: 10}
       └─> {kind: "Average", count: 10}

5. Results Display (Whale.Maui)
   └─> Rank by response time
   └─> Apply converters (emoji, medal colors)
   └─> Show leaderboard with positions
```

### API Endpoint

**`POST /race`** - Race encrypted planktons

**Request:**
```json
{
  "kind": "<AES_encrypted_plankton_type>",
  "count": "<AES_encrypted_count>"
}
```

**Response:**
```json
{
  "kind": "Little|Big|Average",
  "count": 42
}
```

### UI Components

**Value Converters:**
- `PlanktonToEmojiConverter`: Maps plankton types to emojis
  - Little → 🔵 (Blue Circle)
  - Big → 🟢 (Green Circle)
  - Average → 🟡 (Yellow Circle)
- `PositionToColorConverter`: Maps race positions to medal colors
  - #1 → 🥇 Gold (#FFD700)
  - #2 → 🥈 Silver (#C0C0C0)
  - #3 → 🥉 Bronze (#CD7F32)
  - #4+ → Ocean Blue (#3E92CC)

**Color Palette:**
- Ocean Deep: `#0A2463` (Background)
- Ocean Light: `#3E92CC` (Accents)
- Ocean Foam: `#D8F3DC` (Cards)
- Plankton Green: `#52B788` (Quick buttons)
- Coral Orange: `#FB8500` (Primary button)
- Whale Blue: `#2B7A9B` (Count badges)

</details>

---

## 📁 Project Structure

```
Plankton/
├── 📱 src/Front/Whale.Maui/       # The game interface
│   ├── ViewModels/                # UI logic (MainVM)
│   ├── Services/                  # API communication
│   ├── Converters/                # Value converters (Emoji, Color)
│   ├── DisplayObjects/            # Data models (FeedResultItem)
│   ├── Abstractions/              # Interfaces (IAPIService)
│   └── Resources/                 # UI assets
│       ├── Styles/                # Colors and styles
│       └── Images/                # Icons and images
├── 🌐 src/Back/Plankton.API/      # Race server
├── 🔐 src/Kernel/                 # Core libraries
│   ├── Plankton.CryptoHelper/     # Encryption
│   ├── Plankton.RaceHelper/       # Racing engine
│   └── Plankton.DTO/              # Data models
└── README.md                       # You are here!
```

---

## 🧪 Technologies

- **.NET 10** - Modern framework features
- **.NET MAUI** - Cross-platform UI
- **ASP.NET Core** - High-performance API
- **CommunityToolkit.Mvvm** - MVVM helpers
- **AES Encryption** - Secure communication
- **Azure App Service** - Cloud hosting
- **Value Converters** - UI data transformation
- **Border Controls** - Modern MAUI UI elements

---

## 🎓 Learning Objectives

This project demonstrates:
- ✅ **Asynchronous Programming** - Concurrent API calls
- ✅ **Race Conditions** - Task coordination and timing
- ✅ **Cryptography** - AES encryption/decryption
- ✅ **MVVM Architecture** - Clean separation of concerns
- ✅ **Cross-Platform Development** - .NET MAUI
- ✅ **REST API Design** - Minimal APIs with ASP.NET Core
- ✅ **Value Converters** - Data transformation in XAML
- ✅ **Modern UI/UX** - Ocean-themed design with accessibility
- ✅ **Dependency Injection** - Service registration and lifetime management
- ✅ **Dynamic Configuration** - Runtime API endpoint changes

---

## 🎨 UI/UX Highlights

### **Design Philosophy**
The Plankton Game UI embraces an **ocean theme** to create an immersive underwater racing experience:

- **Deep Ocean Background**: Dark blue gradient sets the scene
- **Card-Based Layout**: Information organized in floating cards
- **Visual Hierarchy**: Clear progression from setup to results
- **Instant Feedback**: Status updates and emoji indicators
- **Accessibility First**: Semantic descriptions for screen readers

### **Interactive Elements**
- **Quick-Select Buttons**: One-tap race configuration
- **Dynamic Endpoint**: Change servers without restart
- **Medal System**: Visual reward for top performers
- **Color Coding**: Instant plankton type recognition
- **Smooth Scrolling**: Handles long leaderboards gracefully

---

## 🐛 Troubleshooting

### Common Issues

**Q: Emojis not displaying correctly?**  
A: The app uses Unicode escape sequences for cross-platform emoji support. Ensure your device supports Unicode 13.0+ characters.

**Q: Can't connect to API?**  
A: Verify the endpoint URL is correct. The default `https://planktonapi.azurewebsites.net` should work. If using a custom endpoint, ensure it's accessible and includes `https://`.

**Q: Race results are inconsistent?**  
A: This is expected! The game demonstrates real race conditions where API response times vary. Different runs produce different winners.

**Q: App crashes on startup?**  
A: Ensure you have .NET 10 SDK installed and all NuGet packages restored (`dotnet restore`).

---

## 🤝 Contributing

We welcome contributions! Here's how:

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/amazing-feature`
3. Commit your changes: `git commit -m 'Add amazing feature'`
4. Push to the branch: `git push origin feature/amazing-feature`
5. Open a Pull Request

### Contribution Ideas
- 🎨 New themes (dark mode, light mode)
- 🌍 Localization/internationalization
- 📊 Advanced statistics and charts
- 🎵 Sound effects and animations
- 🏆 Achievement system
- 💾 Race history and replay

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 🎉 Acknowledgments

- **Microsoft** for .NET MAUI and ASP.NET Core
- **CommunityToolkit** for MVVM helpers
- **Azure** for reliable hosting
- The **.NET community** for excellent documentation
- **Unicode Consortium** for emoji standardization 🎨

---

## 📸 Screenshots

> **Note**: The app features a beautiful ocean-themed UI with card-based layout, medal badges, and emoji indicators. Run the app to experience the full visual design!

### Key UI Elements:
- 🌐 **API Configuration Card** - Set your race server
- 🎯 **Race Configuration Card** - Choose plankton count with quick-select
- 🏆 **Leaderboard Card** - Real-time results with medals and emojis
- 💡 **Info Card** - Helpful tips on how the game works

---

<div align="center">

**🐋 Ready to feed the whale? Let the plankton races begin! 🦠**

[⭐ Star this repo](https://github.com/Mafyou/Plankton) | [🐛 Report Bug](https://github.com/Mafyou/Plankton/issues) | [💡 Request Feature](https://github.com/Mafyou/Plankton/issues)

---

*Made with 💙 by the .NET Community*

**v2.0.0** - Now with ocean-themed UI, quick-select buttons, and medal badges!

</div>