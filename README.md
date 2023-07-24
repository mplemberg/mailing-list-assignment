# mailing-list

# Intro

This is a mailing list full stack application that runs from a Visual Studio Solution. It runs a React Front-End on node and .NET Web API in the same solution.

It's compromised of three projects
1. reactapp - React Front End that connects to the webapi
2. webapi - back end for the app
3. webapi.tests - contains unit tests for the back end

# How to Run

1. Open the solution with visual studio
2. Select Start
3. One window will open for the client. another will open with swagger for the api
4. You can use the swagger tool to test the API endpoint to retrieve the mailing list entries, search and sort

# web api overview
3 layers

1. presentation - controllers and view models
2. application - business logic - Command Query Responsibility Segregation pattern
3. data - data and data access - Repository pattern

Run Tests by right-clicking on the webapi.tests project and selecting "Run Tests"

# react app

see [react app readme](reactapp/README.md)


# What I would have done if I had more time
1. Error messages on input fields
2. Clear inputs after submit
3. More test coverage on front-end AND back-end
4. ViewModels for separation of concerns
4. Actual db