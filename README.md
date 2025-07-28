# ?? Plankton Game
*A whale met a plankton. Imagine the REST.*

## ?? Overview

Plankton is a unique racing game built with .NET 9 that demonstrates advanced asynchronous programming concepts through a whale feeding simulation. The whale competes to consume different types of plankton in encrypted races, showcasing real-world scenarios of concurrent API calls, cryptographic operations, and race conditions.

## ??? Architecture

The project follows a clean, modular architecture with multiple specialized libraries:

### ?? **Whale.Maui** - Cross-Platform Client
- **.NET MAUI** application targeting iOS, Android, macOS Catalyst, and Windows
- **MVVM pattern** with CommunityToolkit.Mvvm
- Real-time racing interface with dynamic results display
- Cross-platform UI with accessibility support

### ?? **Plankton.API** - Backend Service
- **ASP.NET Core** minimal API
- Hosted on Azure (planktonapi.azurewebsites.net)
- Encrypted communication endpoint
- Input validation and error handling

### ?? **Plankton.CryptoHelper** - Security Layer
- **AES encryption/decryption** utilities
- Secure data transmission between client and server
- Base64 encoding for safe transport

### ?? **Plankton.RaceHelper** - Concurrent Racing Engine
- Advanced **task racing** and coordination
- Exception handling and resource management
- Dynamic task scheduling and result aggregation

### ?? **Plankton.DTO** - Data Transfer Objects
- Shared contracts between client and server
- Encrypted and decrypted data models
- Type-safe communication

## ? Features

### ?? **Racing Mechanics**
- **Concurrent races** between different plankton types (Little, Big, Average)
- **Real-time competition** using advanced task coordination
- **Encrypted communication** for secure data transmission
- **Dynamic race results** with position tracking

### ?? **Security**
- **AES-256 encryption** for all client-server communication
- **Secure key management** (shared key: `E546C8DF278CD5931069B522E695D4F2`)
- **Input validation** and sanitization
- **Error handling** for tampered data

### ?? **User Experience**
- **Configurable race size** (number of feeds)
- **Live race status** updates
- **Results leaderboard** with rankings
- **Accessibility support** with semantic descriptions
- **Cross-platform consistency**

## ?? Getting Started

### Prerequisites
- **.NET 9 SDK** or later
- **Visual Studio 2022** (17.8+) or **Visual Studio Code**
- For mobile development: **Xcode** (iOS), **Android SDK** (Android)

### ??? Setup Instructions

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Plankton
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the API** (optional - uses hosted version by default)
   ```bash
   cd Plankton.API
   dotnet run
   ```

4. **Run the MAUI app**
   ```bash
   cd Whale.Maui
   dotnet build
   dotnet run --framework net9.0-windows  # For Windows
   # Or use Visual Studio to run on your preferred platform
   ```

### ?? How to Play

1. **Launch the Whale.Maui application**
2. **Enter the number of feeds** you want to race (default: 10)
3. **Click "Ready ?"** to start the race
4. **Watch the real-time race progress** as different plankton types compete
5. **View the final leaderboard** showing race positions and plankton counts

## ?? Technical Implementation

### **Racing Algorithm**
The game uses sophisticated concurrent programming:
- **Parallel task execution** for multiple plankton types
- **Race conditions** managed through `TaskGoup.RaceScopeAsync`
- **Thread-safe result collection** with proper synchronization
- **Cancellation support** for graceful shutdown

### **Encryption Flow**
1. Client encrypts feed data using AES
2. Server receives and validates encrypted payload
3. Server decrypts and processes the race
4. Server returns plain race results
5. Client displays results in real-time

### **Error Handling**
- **Validation** of encrypted payloads
- **Graceful degradation** for network issues
- **User-friendly error messages**
- **Logging** for debugging and monitoring

## ?? Project Structure

```
Plankton/
??? ?? Whale.Maui/           # Cross-platform client app
?   ??? ViewModels/          # MVVM view models
?   ??? Services/            # API communication
?   ??? Platforms/           # Platform-specific code
?   ??? Resources/           # Images, fonts, assets
??? ?? Plankton.API/         # Backend REST API
?   ??? Services/            # Dependency injection
?   ??? Middlewares/         # Request pipeline
?   ??? Helpers/             # Validation utilities
??? ?? Plankton.CryptoHelper/ # Encryption/decryption
??? ?? Plankton.RaceHelper/   # Concurrent racing engine
??? ?? Plankton.DTO/         # Shared data models
```

## ?? API Endpoints

### `POST /race`
**Races encrypted plankton feeds**

**Request Body:**
```json
{
  "kind": "<encrypted_plankton_type>",
  "count": "<encrypted_feed_count>"
}
```

**Response:**
```json
{
  "kind": "Little|Big|Average",
  "count": 42
}
```

## ?? Technologies Used

- **.NET 9** - Latest framework features
- **MAUI** - Cross-platform UI framework
- **ASP.NET Core** - High-performance web API
- **CommunityToolkit.Mvvm** - MVVM helpers
- **System.Security.Cryptography** - AES encryption
- **Azure App Service** - Cloud hosting
- **HttpClient** - HTTP communication

## ?? Development Notes

### **Performance Considerations**
- **Efficient task scheduling** minimizes overhead
- **Resource pooling** for HTTP connections
- **Memory-conscious** encryption operations
- **Responsive UI** with async/await patterns

### **Security Considerations**
- **Symmetric encryption** for performance
- **Key management** (consider key rotation for production)
- **Input validation** prevents injection attacks
- **HTTPS-only** communication

## ?? Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## ?? License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## ?? Acknowledgments

- **Microsoft** for .NET MAUI and ASP.NET Core
- **CommunityToolkit** for MVVM helpers
- **Azure** for reliable hosting
- The **.NET community** for excellent documentation and support

---

*Ready to feed the whale? Let the plankton races begin! ????*