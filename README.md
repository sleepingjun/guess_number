# guess_number  
## Execute `Program.cs` to play the game~  
### todolist  
- [X] 超過次數 game over
- [X] mode normal
- [X] mode hard
- [ ] winner icon 統一->不同
- [ ] Restart → 選擇模式
- [ ] +隱藏模式/自由模式(?
--------------------------------------------------  
# 🎮 lets-play

Ultimate Code — A number guessing game built with C#

> A classic number guessing game, evolving from a command-line tool into a fully playable desktop experience you can share with friends.

---

## 🎯 Goals

- [ ] Refactor existing CLI codebase
- [ ] Add new levels with increasing complexity
- [ ] Build a visual interface (no more terminal needed)
- [ ] Package into a shareable executable for friends
- [ ] Reach complete project standard (see below)

**Complete Project Standard**
> - Non-technical users can understand what this repo does from the README
> - Demo video or screenshots included
> - Clear explanation of game rules, architecture, and how to run
> - Both English and Chinese README provided

---

## 🎲 Game Overview

**Ultimate Code** is a number guessing game where the player tries to guess a secret number within a set number of attempts. Each guess receives feedback to guide the next guess.

| Feature | Current Status | Target |
|---|---|---|
| Core game logic | ✅ Done (CLI) | — |
| Multiple difficulty levels | 🔴 Not started | Add complexity |
| Visual interface | 🔴 Not started | WinForms / MAUI / other |
| Shareable executable | 🔴 Not started | .exe or installer |

---

## 🗺️ Task Structure

> README tracks down to Task level. Sub-tasks are managed in Notion.

```
🏔️ Milestone: Refactored CLI version
  └─ 📦 Feature: Clean, readable codebase
       ├─ ✅ Task: Review and document existing code
       ├─ ✅ Task: Refactor game logic into modules
       └─ ✅ Task: Add file header comments

🏔️ Milestone: New level system
  └─ 📦 Feature: Multiple difficulty levels
       ├─ ✅ Task: Design level structure and rules
       ├─ ✅ Task: Implement level progression logic
       └─ ✅ Task: Playtest and balance

🏔️ Milestone: Visual interface complete
  └─ 📦 Feature: GUI that replaces terminal
       ├─ ✅ Task: Choose GUI framework (WinForms / MAUI / other)
       ├─ ✅ Task: Build main game screen
       ├─ ✅ Task: Connect GUI to game logic
       └─ ✅ Task: Polish UI for non-technical users

🏔️ Milestone: Shareable to friends
  └─ 📦 Feature: Packaged executable
       ├─ ✅ Task: Package as .exe or installer
       ├─ ✅ Task: Test on a clean machine
       └─ ✅ Task: Write Chinese README and demo

🏔️ Milestone: Complete project standard
  └─ 📦 Feature: Docs and demo
       ├─ ✅ Task: Record demo video or screenshots
       └─ ✅ Task: Finalize English + Chinese README
```

---

## 🗂️ Project Structure

```
lets-play/
├── README.md               ← This file (English)
├── README_zh.md            ← Chinese version
├── src/
│   ├── CLI/                ← Original command-line version
│   └── GUI/                ← New visual interface (WIP)
├── docs/
│   └── game-design.md      ← Level design, rules, architecture notes
└── demo/                   ← Screenshots or demo video
```

---

## 🕹️ How to Play (CLI version)

```bash
# Clone the repo
git clone https://github.com/yourusername/lets-play.git

# Navigate to project
cd lets-play/src/CLI

# Run (requires .NET)
dotnet run
```

---

## 🗺️ Roadmap

| Phase | Task | Status |
|---|---|---|
| Phase 1 | Refactor CLI code | 🔴 Not started |
| Phase 2 | Design new level system | 🔴 Not started |
| Phase 3 | Choose and build GUI framework | 🔴 Not started |
| Phase 4 | Package as shareable executable | 🔴 Not started |

---

## 📝 Progress Log

| Date | What I did | Next step |
|---|---|---|
| — | Initialized repo | Review existing CLI code |

---

## 📖 中文說明

請見 [README_zh.md](./README_zh.md)

---

*Last updated: please update this date after each session*
