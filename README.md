# 🎬 CinemaFriendly

CinemaFriendly is a Blazor WebAssembly application that allows users to browse, recommend and comment on movie trailers.

Built using a clean, scalable architecture with focus on testability, modularity, and a great developer experience.

---

## 🧱 Architecture

This project follows a Clean Architecture approach:

- **Domain**: Core entities, enums, and contracts  
- **Application**: Use cases and handlers (CQRS-style)  
- **Infrastructure**: Implementations like repositories, token generators, persistence  
- **Client**: Blazor WASM frontend using Radzen components and MVVM-style ViewModels and Services  
- **Server**: ASP.NET Core Web API layer  
- **Shared**: DTOs and models shared between Server and Client

---

## 🛠️ Technologies Used

- Blazor WebAssembly (.NET 8)
- ASP.NET Core
- Entity Framework Core
- JWT Authentication
- Radzen (for Blazor UI components)
- Clean Architecture Principles
- xUnit / Playwright (upcoming tests)

> ⚙️ Note: This project uses **Radzen** for UI component generation and layout. No external CSS frameworks like Bootstrap are used.

---

## 🚧 Features in progress

- [x] Clean architecture setup  
- [x] JWT token abstraction  
- [x] Trailer DTOs and shared models  
- [x] Blazor structure with ViewModel pattern (Radzen-based)  
- [ ] RESTful API for trailers  
- [ ] Login and register flow  
- [ ] Comments and user interactions  
- [ ] Unit and E2E testing setup

---

## 📦 Getting Started

Clone the repo and open in Visual Studio or use CLI:

```bash
git clone https://github.com/Nicokevo/CinemaFriendly.git
cd CinemaFriendly
dotnet restore
dotnet build
