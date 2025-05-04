# The Guild - Gameplay Loop Team 1 Weekly Report (Week 3)

## Week Overview

This week, our work primarily focused on integrating the combat system into the complete gameplay loop, achieving seamless connections between systems, and enhancing the visual aspects and diversity of combat encounters.

## Key Implementations

### Gameplay Loop Integration

We successfully merged the combat system with the existing gameplay loop, marking a significant milestone:

- Completed the connection between the combat system and dungeon exploration module
- Fixed various errors and conflicts that emerged during the integration process
- The game now supports a complete flow: players can depart from their base, enter dungeon exploration, and naturally transition to combat when encountering enemies

![Transition from dungeon exploration to combat](https://i.imgur.com/AbCd1234.gif)

This integration has transformed the game into a truly cohesive experience, with natural and fluid transitions between modules.

### Combat Visual Enhancements

Beyond system integration, we've made several improvements to the visual presentation of the combat system:

#### Character Animation Refinements

- Replaced previously stiff idle animations, making characters appear more dynamic even when not in action
- Optimized animation transitions to reduce awkwardness between different actions

#### Combat Camera System

- Implemented a dynamic camera system that focuses on and follows the currently active unit during their turn
- Enhanced the dramatic impact and readability of combat, making it easier for players to track battlefield developments

<img src="https://i.imgur.com/uqQeH2L.gif" alt="Characters">
<img src="https://i.imgur.com/nuyIHSQ.gif" alt="Characters">

#### Diverse Combat Environments

- Designed and implemented two entirely new combat scenes, enriching the gameplay experience
- Added a scene randomization system, where players may encounter different environments each time they enter combat
- Each scene features unique visual styling and atmosphere, increasing the game's replay value

<img src="https://i.imgur.com/dLk87LA.gif" alt="Characters">

## Current Work

Currently, we are working closely with Group 2 to discuss and optimize the data sharing mechanism between modules after integration. We're focusing on module communication through GameInstance, ensuring that player progress and character data correctly transfer from the base to dungeons and into combat.

## Final Sprint Plan

For the project's final sprint, we plan to focus on three main areas:

### 1. Module Data Sharing Refinement

- Further optimize the GameInstance structure to ensure effective data sharing between modules
- Implement persistence and synchronization of character attributes, equipment, resources, and other information across modules
- Design clear data workflows to maintain consistency throughout the entire process from base training to combat victory

### 2. Visual Effects Enhancement

- Unify and beautify UI interfaces, providing a consistent visual language throughout the game
- Add more combat effects to enhance visual feedback for skills and status effects
- Further improve scene lighting and environmental details

### 3. Functionality Optimization (Time Permitting)

- Implement a more complete equipment and inventory system
- Add hero recruitment and training functions in the base, creating a positive feedback loop with the combat system
- Include more enemy types and random events to increase gameplay variety

## Conclusion

Week three's work has taken us a critical step closer to a complete game experience. The combat system is no longer an isolated module but has become an integral part of the entire game ecosystem. Through visual enhancements and scene diversification, we've also significantly improved the game's aesthetics and immersion.

In the final sprint, we'll focus on consolidating our achievements and ensuring that all modules function as a cohesive whole through refined data sharing mechanisms. While challenges remain, the team is confident in delivering a complete and engaging game on schedule.