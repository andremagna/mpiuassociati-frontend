# M+Associati – Frontend (ASP.NET MVC Web Application)

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5.3-blue)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.x-purple)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3.3-blueviolet)
![jQuery](https://img.shields.io/badge/jQuery-3.7.1-yellow)
![Isotope](https://img.shields.io/badge/Isotope-Layout-orange)
![Status](https://img.shields.io/badge/Status-Production%20Ready-brightgreen)

---

## 📌 Overview

**M+Associati Frontend** is an ASP.NET MVC 5 web application that serves the public-facing website for the M+Associati engineering studio. It provides:

* A responsive **homepage** with slider, services overview and news section
* **Lo Studio** – team profiles and company presentation
* A dynamic **Projects portfolio** with category filtering (Stradale, Aeroportuale, Idraulica, Fognature, Sanita, Scuole, Sport, Terziario)
* **Servizi** pages: Direzione Lavori, Coordinamento Sicurezza
* **Contatti** page
* Smooth image galleries via **Swiper** slider
* Layout filtering powered by **Isotope**

---

## 🏗️ Architecture

```text
ASP.NET MVC 5 (Razor Views)
        ↓
HomeController / ProgettiController
        ↓
Models (Projects.cs)
        ↓
Backend API (mpiuassociati-backend)
```

---

## 📁 Repository Structure

```text
mpiuassociati-frontend/
│
└── frontend.sln/
    └── frontend/
        ├── frontend.csproj
        ├── Web.config
        │
        ├── Controllers/
        │   ├── HomeController.cs
        │   └── ProgettiController.cs
        │
        ├── Models/
        │   └── Projects.cs
        │
        ├── Views/
        │   ├── Home/
        │   │   ├── Index.cshtml
        │   │   ├── LoStudio.cshtml
        │   │   ├── Contatti.cshtml
        │   │   ├── DirezioneLavori.cshtml
        │   │   └── CoordinamentoSicurezza.cshtml
        │   │
        │   ├── Progetti/
        │   │   ├── Index.cshtml
        │   │   ├── Stradale.cshtml
        │   │   ├── Aeroportuale.cshtml
        │   │   ├── Idraulica.cshtml
        │   │   ├── Fognature.cshtml
        │   │   ├── Sanita.cshtml
        │   │   ├── Scuole.cshtml
        │   │   ├── Sport.cshtml
        │   │   ├── Terziario.cshtml
        │   │   └── Dettagli*.cshtml
        │   │
        │   └── Shared/
        │       └── _Layout.cshtml
        │
        ├── Content/
        │   └── app/
        │       ├── css/ 
        │       └── js/
        │
        ├── Scripts/
        ├── Images/
        └── App_Start/
            ├── RouteConfig.cs
            ├── BundleConfig.cs
            └── FilterConfig.cs
```

---

## 📊 Project Categories

| Category | Route |
|----------|-------|
| Stradale | `/Progetti/Stradale` |
| Aeroportuale | `/Progetti/Aeroportuale` |
| Idraulica | `/Progetti/Idraulica` |
| Fognature | `/Progetti/Fognature` |
| Sanità | `/Progetti/Sanita` |
| Scuole | `/Progetti/Scuole` |
| Sport | `/Progetti/Sport` |
| Terziario | `/Progetti/Terziario` |

---

## 🎨 Frontend Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| Bootstrap | 5.3.3 | Responsive layout & components |
| jQuery | 3.7.1 | DOM manipulation & AJAX |
| Isotope Layout | npm | Portfolio masonry filtering |
| Masonry Layout | npm | Grid layout engine |
| Swiper | custom | Image sliders & carousels |
| Font Awesome | CSS | Icons |

---

## ⚙️ Configuration

File:

```
frontend/Web.config
```

Backend API URL configured in controllers to call the M+Associati backend REST API. Update the API base URL for production deployment.

---

## 🚀 Getting Started

### Prerequisites

* Visual Studio 2022
* .NET Framework 4.x
* IIS or IIS Express

### Run locally

1. Open `frontend.sln` in Visual Studio
2. Set `frontend` as startup project
3. Press **F5** (IIS Express)

The site will be available at:

```
https://localhost:44377
```

---

## 🔒 Security

* HTTPS enforced via `Web.Release.config` transforms
* Input validation via jQuery Validate
* No sensitive data stored client-side

---

## 🚀 Roadmap

* Migrate to ASP.NET Core (Razor Pages or Blazor)
* Server-Side Rendering optimization
* CDN for static assets
* CMS integration for project management

---

## 📄 License

© 2026 - Andrea Magnaghi

---

## 👨‍💻 Version

```
1.0.0
```
