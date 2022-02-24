# Lab 19: Roles

## The Problem Domain

Keep building off of your Async Inn and add roles to your app

## Application Specifications

Add 3 new roles to your application with the following permissions:

1. District Manager
- District manager can do full CRUD operations on all Hotel, HotelRoom, Room, and Amenity entities.
- The district manager can create accounts for all other roles
2. Property Manager
- Property Manager's can add/update/read new HotelRooms to hotels, and amenities to rooms. A property manager cannot create new room entities or hotel entities.
- The property manager can only create accounts for Agents
3. Agent
- An agent can only update/read a HotelRoom and add/delete amenities to rooms
4. Anonymous users
- anonymous users can only view all GET routes

All routes should be locked down to Authorize. Override the `[AllowAnonymous]`on the appropriate routes for anonymous users.

The District Manager and Property

## Guidance
1. Be sure to seed your roles into the database
2. Seed in a default district manager account into your database
3. Use the JWT token setup to return a JWT token after every login.
4. Test your routes through Postman

## Unit Tests
1. Write tests for at least one service, covering all the public methods.

## Stretch Goals
- Test more services
- add additional permissions/routes onto your controllers for additional functionality.

## Additional Resources
- There are no additional resources provided for this assignment.

## README

**A Readme is a requirement. No Readme == No Grade.**
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. Tell them what it is (with context, provide a summary)
1. Show them what it looks like in action (Visuals)
1. Show them how they use it (Step by step directions, "Happy Path" walk through)
1. Tell them any other relevant details
<br />

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example.
- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}


## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new branch named `NAME-AsyncFinal` in your `AsyncInn` repository
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
