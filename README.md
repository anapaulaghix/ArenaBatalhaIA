# 🐉 Battle Arena – Third-Person 3D Unity Game

## 📖 Project Description

**Battle Arena** is a **third-person 3D game** developed with **Unity**, where the player fights waves of enemies inside an arena.  
Enemies are spawned dynamically using a **spawner system** and are controlled by **Artificial Intelligence (AI)** that allows them to detect and move toward the player.

When defeated, enemies **catch on fire**, triggering a visual fire effect using a **Particle System**, enhancing visual feedback and immersion.

This project focuses on gameplay systems such as:
- Third-person character control
- Enemy AI and navigation
- Combat mechanics
- Visual effects and particles
- Enemy spawning systems

---

## 🎮 Main Features

### 🕹️ Third-Person Player Controller
- Third-person camera system
- Smooth character movement and rotation
- Player-controlled combat mechanics
- Arena-based combat
<img width="500" height="447" alt="Jogo" src="https://github.com/user-attachments/assets/caf18ad6-4517-4de8-b8e4-db2e084b945e" />


### 🧠 Enemy Artificial Intelligence
- Player detection by distance
- AI movement using **NavMeshAgent**
- Automatic chase behavior toward the player
- Attack when within range
- Multiple enemies acting simultaneously

### 🔥 Enemy Death Fire Effect
- When an enemy’s HP reaches **0**, it:
  - Plays a death animation
  - Disables its collider
  - Triggers a **fire Particle System**
- Fire effect is attached to the enemy’s body
- The effect activates **only on death**
<img width="500" height="438" alt="2025-12-15 21_36_10-Window" src="https://github.com/user-attachments/assets/a3d34ff8-9766-4d0a-88a8-3dd1dca84395" />

### 🧬 Enemy Spawner System
- Enemies are spawned at predefined points in the arena
- Supports multiple enemies and waves
- Keeps gameplay dynamic and challenging
<img width="500" height="437" alt="2025-12-15 21_36_27-Window" src="https://github.com/user-attachments/assets/221eff44-9777-47d6-9806-06072daf3144" />


---

## 🛠️ Technologies Used

- **Unity 3D** (version 6000.1.11f)
- **C#**
- **NavMeshAgent**
- **Animator Controller**
- **Particle System**
- Free assets from the **Unity Asset Store**

---
