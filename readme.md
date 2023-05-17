# About

This is a refactoring exercise intended for technical interviews for dotnet software engineer candidates.

# Pre-Reqs

1. The `RefactoringExercise` project makes api calls, as such it has a dependency on the `Mock` project. The `Mock` project
    spins up a mock server. You will need to start the `Mock` project before running the `RefactoringExercise` project.

# Instructions

This is a legacy application. There is a static `UserService` class with a static `AddUser` method. There are several
things that are not ideal with this class/method and overall project structure.

It is your job to refactor this implementation such that one happy path unit test can be written to test the `AddUser` method.