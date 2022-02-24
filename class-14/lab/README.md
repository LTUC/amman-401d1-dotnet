# Lab 14: Navigation Properties & Routing

## The Problem Domain

Continue working on your AsyncInn and add the following:

### RoomAmenities

1. Add onto your `RoomsController` the ability to add and remove amenities to a specific room
   - Routes: POST/DELETE: `[Route("{roomId}/Amenity/{amenityId}")]`
   - Add to your `IRoom` Interface the method signatures to `AddAmenityToRoom(int roomId, int amenityId)` and `RemoveAmentityFromRoom(int roomId, int amenityId)`
   - Add the logic for the above methods into your `RoomRepository.cs` Service.
1. Add to your `Room.cs`, `Amenity.cs`, and `RoomAmenity.cs` file the navigation properties that we defined in your ERD.
1. On the `Get()` based call in your `RoomRepository.cs` and your 'AmenityRepository.cs` file, use the `Include()` to populate the navigation property details within the return object.

### HotelRoom

1. Create a new interface named `IHotelRoom` that contains basic CRUD operations for manipulating a HotelRoom.
2. Create a service named `HotelRoomRepository` that implements the `IHotelRoom` interface. Add the logic for each of the methods to satisfy the CRUD operations on a HotelRoom.
3. Scaffold out a new HotelRoomController that will inject the IHotelRoomInterface. Update/customize the logic to use the interface instead of the DBContext
4. Modify the routes of this controller for the following:

- GET all the rooms for a hotel: `/api/Hotels/{hotelId}/Rooms`
- POST to add a room to a hotel: `/api/Hotels/{hotelId}/Rooms`
- GET all room details for a specific room: `/api/Hotels/{hotelId}/Rooms/{roomNumber}`
- PUT update the details of a specific room: `/api/Hotels/{hotelId}/Rooms/{roomNumber}`
- DELETE a specific room from a hotel: `/api/Hotels/{hotelId}/Rooms/{roomNumber}`

### Misc

1. Be sure that all navigation properties are present in all models.
1. Be sure that when you query a room, you get all the amenities attached to it
1. BE sure that when you query an Amenity, you get all the rooms associated with it.
1. Be sure that when you query a HotelRoom, you get all the Rooms that are associated with it(which should also have all the amenitites)
1. Be sure that when you query a Hotel, you get all the Rooms (which should contain all the information from the option above)

## Stretch Goals

1. Add the ability within your HotelController to "find a hotel by name"

## README

Update your README to showcase all of your routes with example data objects that get returned.

## Rubric

The lab rubric can be found [Here](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a new branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in Canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
