# Peer Project Review: DocTient (CSIT321)

**Reviewer:** Quibuyen
**Project:** DocTient, a Blazor WebAssembly healthcare app connecting patients and doctors
**Author (per commit history):** Ycany-Sanchez

---

## Project Structure Rating: 9 / 10

The repository is organized in the standard Blazor WebAssembly layout, and I could find anything I looked for without confusion. Each page (`Home`, `Login`, `Signup`, `Dashboard`, `Feedback`) has its own file in `Pages/`, the layout is in `Layout/`, and the static assets (`index.html`, `css/app.css`) are in `wwwroot/`. The file names are clear and consistently PascalCase, so a reader can tell what each file does from its name alone. Routing, root components and imports are kept in their conventional places (`App.razor`, `Program.cs`, `_Imports.razor`), which makes the entry points easy to follow.

The repository is clean. `.gitignore` excludes `bin/`, `obj/`, `.vs/` and `*.user`, so no build output or editor files are tracked, and the solution (`DocTient.sln`) and project (`DocTient.csproj`) files are at the root. The commit history is short and linear, and it shows how the project grew: the initial app, the migration from plain CSS to Tailwind, the glassmorphism styling, animations, the Rate Doctor screen, and the dashboard cleanup. The commit messages use conventional prefixes (`feat:`, `fix:`, `refactor:`), so the type of each change is easy to scan. Overall, the structure makes the project easy to navigate, read and maintain.

---

## Front-End Rating: 10 / 10

The interface is polished and cohesive. It uses a dark navy glassmorphism theme with blurred translucent cards, soft gradient blobs, a dot-grid background and sky-blue accents. The same fonts (DM Sans and Inter), card style, rounded corners and button styling are used across Home, Login, Signup, Dashboard and Feedback, so the app looks like one product. The text hierarchy is clear, with large headings, small muted captions and uppercase labels, so each screen is easy to read.

The dashboard is the strongest page. It has a heart-rate hero card with an animated heartbeat, colour-coded status badges (green "Normal", amber "Monitor"), a medication list and a sidebar that can be collapsed. The entrance animations and card hover-lift effects add polish without getting in the way. Usability is also good. Login and Signup have clear Patient/Doctor role tabs, inline error messages and a "Signing in..." loading state, and the sidebar and "Back to home" links make navigation simple. The Rate Doctor screen is a complete feature, with a hover star rating, quick-select tags, a character-limited comment, validation and a highlighted active menu item. A custom 404 page and a loading spinner in `index.html` show attention to detail.

The layout is responsive. On mobile the sidebar becomes a slide-in drawer with a backdrop, the card grid collapses from three columns to one, and the content width is capped for comfortable reading. Overall the front end is visually impressive, consistent and easy to use.
