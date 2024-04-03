// Define the Coach record
type Coach = {
    Name: string
    FormerPlayer: bool
}

// Define the Stats record
type Stats = {
    Wins: int
    Losses: int
}

// Define the Team record
type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

// Create coaches based on provided data
let coaches = [
    { Name = "Jatin "; FormerPlayer = true }
    { Name = "Abhishek"; FormerPlayer = true }
    { Name = "Surya "; FormerPlayer = false }
    { Name = "Arjun"; FormerPlayer = false }
    { Name = "Ankur "; FormerPlayer = false }
]

// Create stats based on provided data
let stats = [
    { Wins = 48; Losses = 24 }
    { Wins = 58; Losses = 60 }
    { Wins = 45; Losses = 27 }
    { Wins = 46; Losses = 50 }
    { Wins = 52; Losses = 20 }
]

// Create teams using coaches and stats
let teams = [
    { Name = "USA NBA"; Coach = coaches.[0]; Stats = stats.[0] }
    { Name = "Brazil NBA  "; Coach = coaches.[1]; Stats = stats.[1] }
    { Name = "Canada NBA "; Coach = coaches.[2]; Stats = stats.[2] }
    { Name = "Berlin NBA "; Coach = coaches.[3]; Stats = stats.[3] }
    { Name = "Germany NBA"; Coach = coaches.[4]; Stats = stats.[4] }
]

// Filtering successful teams
let successfulTeams = teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)
printfn "SuccessfulTeams"
successfulTeams |> List.iter (fun team ->
    printfn "%s" team.Name)
// Mapping success percentage
let successPercentages = successfulTeams |> List.map (fun team -> 
    let wins = float team.Stats.Wins
    let losses = float team.Stats.Losses
    let successPercentage = (wins / (wins + losses)) * 100.0
    (team.Name, successPercentage)
)

// Print success percentages
printfn "Success percentage "
successPercentages |> List.iter (fun (name, percentage) -> 
    printfn "%s: %.2f%%" name percentage
)
