# Lab 13: Dependency Injection & Repository Design Pattern

## The Problem Domain

Building off of your current project, refactor your project to allow and implement dependency injection. We want to keep the current behavior of our API server the same, and only refactoring the architecture.

## Application Specifications

### Repository Design Pattern

1. Using Dependency Injection, refactor your `Hotels`, `Rooms`, and `Amenities` Controllers to depend on an interface rather than the DbContext.

1. Build an interface for each of the controllers that contain the required method signatures to all for CRUD operations to the database directly

1. Update each of the controllers to inject the interface rather than the DBContext

1. Create a service for each of the controllers that implement the appropriate interface. Build out the logic to satisfy the interface by making the appropriate calls to the db for each action.

1. Update your Controller to use the appropriate method from the interface rather than the DBContext directly.

1. Confirm in POSTMAN that your controllers are returning the same logic as they did in Lab 12.

## README

Update your README to contain information about your architecture. Add a section that, in your own words, discusses what the architecture pattern is and how it is used in the app.

## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a branch on your Async Inn project named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
