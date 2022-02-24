# Lab 16: Data Transfer Objects (DTOs)

## The Problem Domain

Add onto your current Async Inn application by cleaning up input and outputs of your controllers to be DTOs.

Hint: Order you should consider building your DTOs:
DTOs stand for data transfer objects

1. Amenities,
2. Rooms
3. HotelRooms
4. Hotels

### Routes and Responses

#### HotelsController

Route (GET): api/Hotels/{id}:

Here is the expected output when calling Hotels:

```json
{
    "id": 1,
    "name": "My really cool Hotel",
    "streetAddress": "123 CandyCane Lane",
    "city": "Seattle",
    "state": "WA",
    "phone": "123-456-8798",
    "rooms": [
        {
            "hotelID": 1,
            "roomNumber": 101,
            "rate": 75.00,
            "petFriendly": false,
            "roomID": 2,
            "room": {
                "id": 2,
                "name": "Queen Suite",
                "layout": "TwoBedroom",
                "amenities": [
                    {
                        "id": 1,
                        "name": "Coffee Maker"
                    },
                    {
                        "id": 2,
                        "name": "Mini Bar"
                    }
                ]
            }
        },
        {
            "hotelID": 1,
            "roomNumber": 123,
            "rate": 120.00,
            "petFriendly": true,
            "roomID": 1,
            "room": {
                "id": 1,
                "name": "Princess Suite",
                "layout": "OneBedroom",
                "amenities": [
                    {
                        "id": 1,
                        "name": "Coffee Maker"
                    },
                    {
                        "id": 2,
                        "name": "Mini Bar"
                    }
                ]
            }
        }
    ]
}
```

Route: (GET) :  'api/Hotels'

```text
An array of individual hotels. (See result from api/Hotels/{id})
```

#### HotelRooms Controller

Route: (Get/Put/Delete) : `/api/Hotels/{hotelId}/Rooms/{roomNumber}`

- This is the HotelRooms Controller
- Create, Read, Update, Delete a hotel room
- THe PUT request will include the HotelRoomDTO in the incoming request from the client

Route: (Get/Post) : `/api/Hotels/{hotelId}/Rooms`

- Get all the rooms for a hotel
- Add a single room to a hotel
  - When adding a room, the HotelRoomDTO will be the incoming request from the client

```json
{
    "hotelID": 1,
    "roomNumber": 101,
    "rate": 75.00,
    "petFriendly": false,
    "roomID": 2,
    "room": {
        "id": 2,
        "name": "Queen Suite",
        "layout": "TwoBedroom",
        "amenities": [
            {
                "id": 1,
                "name": "Coffee Maker"
            },
            {
                "id": 2,
                "name": "Mini Bar"
            }
        ]
    }
}
```

#### Rooms Controller

Route (Get/Put) : `api/rooms/{roomId}`

- Get a specific room
- Update a room

```json
{
    "id": 1,
    "name": "Princess Suite",
    "layout": "OneBedroom",
    "amenities": [
        {
            "id": 1,
            "name": "Coffee Maker"
        },
        {
            "id": 2,
            "name": "Mini Bar"
        }
    ]
}
```

Route: (GET/POST) : `api/rooms/`

- Get an array of RoomDTO objects
- refer to request above for formatting
- Post request will create a new room
- Post request will have the room DTO included in request

#### Amenities Controller

Route: (Get) `api/amenities/{id}`

- Get specific amenity

```json
{
    "id": 1,
    "name": "Coffee Maker"
}
```

Route: (GET/POST) - `api/amenities/`

- Get all Amenities
- Response will be an array of amenities
- Post is adding a new general amenity
- Post will include the Amenities DTO in the request

## Guidance

Create DTOs that will be accepted and returned to the user:

```csharp
    public class HotelDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public List<HotelRoomDTO> Rooms { get; set; }
    }


    public class HotelRoomDTO
    {
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }
        public int RoomID { get; set; }
        public RoomDTO Room { get; set; }
    }

    public class RoomDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Layout { get; set; }
        public List<AmenityDTO> Amenities { get; set; }
    }

    public class AmenityDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
```

## Unit Tests

Not Required.

## Stretch Goals

- Test your other methods
- Figure out how to cascade delete

## README

**A Readme is a requirement. No Readme == No Grade.**
Here are the requirements for a valid readme:

A README is a module consumer's first -- and maybe only -- look into your creation. The consumer wants a module to fulfill their need, so you must explain exactly what need your module fills, and how effectively it does so.

Your job is to

1. tell them what it is (with context, provide a summary)
1. show them what it looks like in action (Visuals)
1. show them how they use it (Step by step directions, "Happy Path" walk through)
1. tell them any other relevant details

This is ***your*** job. It's up to the module creator to prove that their work is a shining gem in the sea of slipshod modules. Since so many developers' eyes will find their way to your README before anything else, quality here is your public-facing measure of your work.

Refer to the README templates in the class repo `Resources` folder for an example.

- [Reference](https://github.com/noffle/art-of-readme){:target="_blank"}

## Rubric

The lab rubric can be found [HERE](../../resources/rubric){:target="_blank"}

## To Submit this Assignment

- Create a branch named `NAME-LAB##`
- Write your code
- Commit often
- Push to your repository
- Create a pull request from your branch back your `main` branch.
- Submit a link to your PR in canvas
- Merge your PR back into main
- In Canvas, Include the actual time it took you to complete the assignment as a comment (**REQUIRED**)
- Include a `README.md` (contents described above)
