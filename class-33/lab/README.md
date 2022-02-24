# E-Commerce Sprint 2 - Milestone 3:  Notifications

Work together with your partner(s) to complete this lab.

> NOTE: Your team workflow will live in Azure Dev Ops. Use this tool to store your project repository code, user stories, and general overall workflow.[Azure DevOps CheatSheet](https://codefellows.github.io/code-401-dotnet-guide/curriculum/projects/ecommerce/azure-devops-cheatsheet)

Your team will be evaluated and graded at the end of every sprint for the individual milestones and overall presentation of the sprint/project. Each day the previous day's milestones build off each other as the project progresses. Stay on top of your work, **Communicate**, and work together.

## Consumer Site (The Storefront)

The cart is full and our customer is ready to make a purchase. Focusing on that workflow, we'd like to give them ability to enter their payment information and begin the order finalization process.

For this milestone, our goal is simply to create the final 2 pages in the workflow (order and receipt) and execute the communications process ... not to accept payment and process the order.

### User Stories and Tasks

Divide your work evenly amongst your team members.

1. As a user,  I would like to see a summary of my purchase after completing my checkout process.
1. As a user, I would like a summary of my purchase to be emailed to me so that I can store the receipt for my records.
1. As a user, I would like to be thanked for my purchase following completion of order processing
1. As an administrator, I would like a copy of all purchases emailed to our sales department so that they can update our accounting system
1. As an administrator, I would like a copy of all purchases emailed to our warehouse so that they can begin the fulfillment process

### Guidance / Questions

### Guidance

- Does each person in the emails require the same information?
- When creating emails, consider using the SendGrid design templates. Not required, but encouraged.
- Also consider using `StringBuilder` when creating the text for the email, this is much more efficient than concatenating a string together.
- Question: At what point in the process do emails get sent?

## Tests

- No new tests required

## To Submit this Assignment

- Continue to work in your `E-Commerce-App` repository
- Name your repo `E-Commerce-App`
- Create a branch named `sprint-#-milestone-#`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
