# Unity Service Locator Pattern Example

## Overview

This project demonstrates the implementation of the Service Locator pattern in Unity. The pattern helps to manage dependencies and services in a more flexible way by decoupling service providers from their consumers. This example includes a simple scene with a cube that can move in response to input, play sounds, and update a score.

## Components

### Scripts

1. **`AudioService`**
   - Implements the `IAudioService` interface.
   - Provides functionality to play sounds.
   
2. **`CubeController`**
   - Controls the movement of the cube and interacts with the services.
   - Uses `IMovementService`, `IAudioService`, and `IScoreService` to manage cube behavior.
   
3. **`CubeMovementService`**
   - Implements the `IMovementService` interface.
   - Handles movement of the cube.
   
4. **`FootSteps`**
   - Manages the `AudioSource` component to play footstep sounds when the cube is moving.
   
5. **`GameController`**
   - Registers services with the `ServiceLocator` at the start of the game.
   
6. **`ScoreService`**
   - Implements the `IScoreService` interface.
   - Manages and tracks the score.

7. **`ServiceLocator`**
   - Provides a static way to register and retrieve services throughout the application.

### Interfaces

1. **`IAudioService`**
   - Defines the contract for audio services.
   
2. **`IMovementService`**
   - Defines the contract for movement services.
   
3. **`IScoreService`**
   - Defines the contract for score services.

