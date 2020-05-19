Imports System
Imports System.Threading

Public Module Module1
	Public UKAirport As String
	Public OverseasAirport As String
	Public Distance As Integer
	Public AircraftType As String
	Public MaxFlightRange As Integer
	Public RunningCost As Integer
	Public maxStandard As Integer
	Public mininumFirstClass As Integer
	Public firstClassSeats As Integer
	Public standardClassSeat As Integer
	Public standardPrice As Double
	Public firstClassPrice As Double
	Public costPerSeat As Double
	Public flightCost As Double
	Public flightIncome As Double
	Public flightProfit As Double
	Public UKAirportSelected As Boolean
	Public OverseasAirportSelected As Boolean
	Public AircraftSelecteds As Boolean
	Public FirstClassSelected As Boolean
	Public AbleToArrive As Boolean

	Public Structure AirportData
		Dim AirportCode As String
		Dim AirportName As String
		Dim DistanceFromLPL As String
		Dim DistanceFromBOH As String
	End Structure

	Public Structure AircraftData
		Dim Type As String
		Dim RunningCostPerSeat As String
		Dim FlightRange As Integer
		Dim MaxCapacityStandard As Integer
		Dim MinimumFirstClasss As Integer
	End Structure

	Dim Airports(0 To 4) As AirportData
	Dim Aircrafts(0 To 2) As AircraftData

	Public Sub Main()
		Dim launched As Boolean
		If launched = False Then
			AddAirports()
			AddAircraft()
		End If

Main:
		launched = True
		Console.Clear()
		Dim temp As String
		Console.WriteLine("Enter Airport (airport)")
		Console.WriteLine("Enter Aircraft (aircraft)")
		Console.WriteLine("Enter Price Plan (profit)")
		Console.WriteLine("Clear Data (clear)")
		Console.WriteLine("Quit")
		Console.Write("> ")
		temp = Console.ReadLine().ToLower()
		If temp = "airport" Then
			Airport()
		ElseIf temp = "aircraft" Then
			Aircraft()
		ElseIf temp = "profit" Then
			Profit()
		ElseIf temp = "clear" Then
			Clear()
		ElseIf temp = "quit" Then
			Quit()
		Else
			Console.WriteLine("Input not recognised!")
			Console.WriteLine("Please press 'Enter' to continue..")
			Console.ReadLine()
			GoTo Main
		End If

	End Sub

	Sub Airport()

		Dim OverseasAirportCode As String
		Dim UkAirportCode As String
		Dim isLPL As Boolean
		Dim isBOH As Boolean
		Console.Clear()
		Console.WriteLine("Please enter the UK Airport CODE you will be flying from... (LPL) or (BOH)")
		Console.Write("> ")
		UkAirportCode = Console.ReadLine().ToUpper
		If UkAirportCode = "LPL" Then
			isLPL = True
			isBOH = False
			UKAirport = "Liverpool John Lennon"
		ElseIf UkAirportCode = "BOH" Then
			isBOH = True
			isLPL = False
			UKAirport = "Bournemouth International"
		Else
			Console.WriteLine("Input not recognised please refer to the brackets shown for your selection!")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Airport()
		End If
		UKAirportSelected = True
Overseas:
		Console.WriteLine("Please enter the overseas airport CODE:")
		Console.Write("> ")
		OverseasAirportCode = Console.ReadLine().ToUpper()

		If OverseasAirportCode = Airports(0).AirportCode Then
			Console.WriteLine("Overseas Airport Selected: " & Airports(0).AirportName)
			OverseasAirport = Airports(0).AirportName
			If isLPL = True Then
				Distance = Airports(0).DistanceFromLPL
			ElseIf isBOH Then
				Distance = Airports(0).DistanceFromBOH
			End If
		ElseIf OverseasAirportCode = Airports(1).AirportCode Then
			Console.WriteLine("Overseas Airport Selected: " & Airports(1).AirportName)
			OverseasAirport = Airports(1).AirportName
			If isLPL = True Then
				Distance = Airports(1).DistanceFromLPL
			ElseIf isBOH Then
				Distance = Airports(1).DistanceFromBOH
			End If
		ElseIf OverseasAirportCode = Airports(2).AirportCode Then
			Console.WriteLine("Overseas Airport Selected: " & Airports(2).AirportName)
			OverseasAirport = Airports(2).AirportName
			If isLPL = True Then
				Distance = Airports(2).DistanceFromLPL
			ElseIf isBOH Then
				Distance = Airports(2).DistanceFromBOH
			End If
		ElseIf OverseasAirportCode = Airports(3).AirportCode Then
			Console.WriteLine("Overseas Airport Selected: " & Airports(3).AirportName)
			OverseasAirport = Airports(3).AirportName
			If isLPL = True Then
				Distance = Airports(3).DistanceFromLPL
			ElseIf isBOH Then
				Distance = Airports(3).DistanceFromBOH
			End If
		ElseIf OverseasAirportCode = Airports(4).AirportCode Then
			Console.WriteLine("Overseas Airport Selected: " & Airports(4).AirportName)
			OverseasAirport = Airports(4).AirportName
			If isLPL = True Then
				Distance = Airports(4).DistanceFromLPL
			ElseIf isBOH Then
				Distance = Airports(4).DistanceFromBOH
			End If
		Else
			Console.WriteLine("Input not recognised!")
			Console.WriteLine("Please press any key to continue..")
			Console.ReadKey()
			GoTo Overseas
		End If
		OverseasAirportSelected = True
		Console.ReadLine()
		Main()
	End Sub

	Sub Aircraft()
		Dim aircraftSelected As String
		Console.WriteLine("Aircraft Menu")
		Console.Clear()
		Console.WriteLine("Please enter the aircraft you want to use?:")
		Console.WriteLine(Aircrafts(0).Type & vbNewLine & Aircrafts(1).Type & vbNewLine & Aircrafts(2).Type)
		Console.Write("> ")
		aircraftSelected = Console.ReadLine().ToLower()
		If aircraftSelected = "medium narrow body" Then
			Console.WriteLine("Aircraft Selected: " & Aircrafts(0).Type)
			AircraftType = Aircrafts(0).Type
			RunningCost = Aircrafts(0).RunningCostPerSeat
			MaxFlightRange = Aircrafts(0).FlightRange
			maxStandard = Aircrafts(0).MaxCapacityStandard
			mininumFirstClass = Aircrafts(0).MinimumFirstClasss
		ElseIf aircraftSelected = "large narrow body" Then
			Console.WriteLine("Aircraft Selected: " & Aircrafts(1).Type)
			AircraftType = Aircrafts(1).Type
			RunningCost = Aircrafts(1).RunningCostPerSeat
			MaxFlightRange = Aircrafts(1).FlightRange
			maxStandard = Aircrafts(1).MaxCapacityStandard
			mininumFirstClass = Aircrafts(1).MinimumFirstClasss
		ElseIf aircraftSelected = "medium wide body" Then
			Console.WriteLine("Aircraft Selected: " & Aircrafts(2).Type)
			AircraftType = Aircrafts(2).Type
			RunningCost = Aircrafts(2).RunningCostPerSeat
			MaxFlightRange = Aircrafts(2).FlightRange
			maxStandard = Aircrafts(2).MaxCapacityStandard
			mininumFirstClass = Aircrafts(2).MinimumFirstClasss
		Else
			Console.WriteLine("Aircraft not recognised")
			Console.WriteLine("Please try again")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Aircraft()
		End If
aircraftStats:

		Console.Clear()
		Console.WriteLine("Aircraft selected: " & AircraftType)
		Console.WriteLine("Running cost per seat: £" & RunningCost)
		Console.WriteLine("Maximum flight range: " & MaxFlightRange & "km")
		Console.WriteLine("Maximum seats: " & maxStandard & " Seats")
		Console.WriteLine("Mininum of First Class seats (if there are any): " & mininumFirstClass & " Seats")
		Dim halfOfStandard As Integer = maxStandard / 2
		Console.WriteLine("Press any key to continue")
		Console.Write("> ")
		Console.ReadKey()
		Console.Clear()
		AircraftSelecteds = True
		Console.WriteLine("How many First Class Seats would you like to have on your flight? (Mininum First Class Seats: " & mininumFirstClass & ")")
		Console.Write("> ")
		firstClassSeats = Console.ReadLine()
		If firstClassSeats = 0 Then
			standardClassSeat = maxStandard
		ElseIf firstClassSeats > 0 And firstClassSeats < mininumFirstClass Then
			Console.WriteLine("There is not enought first class seats to exceed the minimum amount of first class seats!")
			Console.WriteLine("Please try again!")
			Console.WriteLine("Press any key to continue!")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		ElseIf firstClassSeats > halfOfStandard Then
			Console.WriteLine("There are too many first class seats here!")
			Console.WriteLine("The maximum amount of first class seats is half of the maximum of standard seats!")
			Console.WriteLine("Please consult the stats you are given above.")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		ElseIf firstClassSeats > mininumFirstClass Or firstClassSeats = mininumFirstClass Then
			standardClassSeat = maxStandard - firstClassSeats * 2
			Console.WriteLine("Amount of Standard Seats: " & standardClassSeat & " Seats" & vbNewLine & "Amount of First Class Seats: " & firstClassSeats & " Seats")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			FirstClassSelected = True
			Main()
		End If

	End Sub

	Sub Profit()
		Console.Clear()
		If UKAirportSelected = False Then
			Console.WriteLine("Please Select a Departing Airport!")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		End If
		If OverseasAirportSelected = False Then
			Console.WriteLine("Please Select a Arriving Airport!")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		End If
		If AircraftSelecteds = False Then
			Console.WriteLine("Please Select a Aircraft!")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		End If
		If FirstClassSelected = False Then
			Console.WriteLine("Please declare some First Class Seats! (If there are any)")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		End If
		If Distance > MaxFlightRange Then
			Console.WriteLine("Please pick a differnet Aircraft you need to exceed {0}km", Distance)
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadKey()
			Main()
		End If
		Console.WriteLine("How much do you want to charge for your Standard Class Seat?")
		Console.Write("> ")
		standardPrice = Console.ReadLine()
		Console.WriteLine("How much do you want to charge for your First Class Seat?")
		Console.Write("> ")
		firstClassPrice = Console.ReadLine()
		costPerSeat = RunningCost * Distance / 100
		flightCost = costPerSeat * (firstClassSeats + standardClassSeat)
		flightIncome = firstClassSeats * firstClassPrice + standardPrice * standardClassSeat
		flightProfit = flightIncome - flightCost
		Console.WriteLine("UK Airport: " & UKAirport)
		Console.WriteLine("Overseas Airport: " & OverseasAirport)
		Console.WriteLine("Distance: {0}km", Distance)
		Console.WriteLine("Type of Aircraft: " & AircraftSelecteds)
		Console.WriteLine("Maximum Flight Range: " & MaxFlightRange & " kilometres")
		Console.WriteLine("Running cost per seat per 100 Kilometres: £" & RunningCost)
		Console.WriteLine("Capacity if all seats are Standard Class: " & maxStandard)
		Console.WriteLine("Number of First Class Seats: " & firstClassSeats)
		Console.WriteLine("Number of Standard Class Seats: " & standardClassSeat)
		Console.WriteLine("Price of Standard Class Seat: £" & standardPrice)
		Console.WriteLine("Price of First Class Seat: £" & firstClassPrice)
		Console.WriteLine("Flight cost per seat: £" & costPerSeat)
		Console.WriteLine("Flight Cost: £" & flightCost)
		Console.WriteLine("Flight Income: £" & flightIncome)
		Console.WriteLine("Flight Profit: £" & flightProfit)
		Console.WriteLine("")
		Console.WriteLine("Press any key to continue...")
		Console.Write("> ")
		Console.ReadKey()
		Main()
	End Sub

	Sub Clear()
		Console.Clear()
		Dim temp As String
		Console.WriteLine("Are you sure you want to clear all your data? y/n")
		Console.Write("> ")
		temp = Console.ReadLine().ToLower()
		If temp = "y" Then

		ElseIf temp = "n" Then
			Main()
		Else
			Console.WriteLine("Please type y or n!")
			Console.WriteLine("Press any key to continue...")
			Console.Write("> ")
			Console.ReadLine()
			Clear()
		End If
		Console.WriteLine("Clearing Data!")
		Thread.Sleep(1000)
		UKAirport = ""
		OverseasAirport = ""
		Distance = 0
		AircraftType = ""
		MaxFlightRange = 0
		RunningCost = 0
		maxStandard = 0
		mininumFirstClass = 0
		firstClassSeats = 0
		standardClassSeat = 0
		standardPrice = 0
		firstClassPrice = 0
		costPerSeat = 0
		flightCost = 0
		flightIncome = 0
		flightProfit = 0
		UKAirportSelected = False
		OverseasAirportSelected = False
		AircraftSelecteds = False
		FirstClassSelected = False
		AbleToArrive = False
		Console.WriteLine()
		Console.WriteLine("Cleared!")
		Console.WriteLine("Press any key to continue...")
		Console.ReadKey()
		Main()
	End Sub

	Sub Quit()
		Console.WriteLine("Quitting")
		Thread.Sleep(1000)
		Environment.Exit(1)
	End Sub
	Sub AddAirports()
		Dim line1() As String
		Dim line2() As String
		Dim line3() As String
		Dim line4() As String
		Dim line5() As String
		FileOpen(1, "Airports.txt", OpenMode.Input)
		line1 = LineInput(1).Split(",")
		line2 = LineInput(1).Split(",")
		line3 = LineInput(1).Split(",")
		line4 = LineInput(1).Split(",")
		line5 = LineInput(1).Split(",")
		FileClose(1)

		Airports(0).AirportCode = line1(0)
		Airports(0).AirportName = line1(1)
		Airports(0).DistanceFromLPL = Convert.ToInt32(line1(2))
		Airports(0).DistanceFromBOH = Convert.ToInt32(line1(3))

		Airports(1).AirportCode = line2(0)
		Airports(1).AirportName = line2(1)
		Airports(1).DistanceFromLPL = Convert.ToInt32(line2(2))
		Airports(1).DistanceFromBOH = Convert.ToInt32(line2(3))

		Airports(2).AirportCode = line3(0)
		Airports(2).AirportName = line3(1)
		Airports(2).DistanceFromLPL = Convert.ToInt32(line3(2))
		Airports(2).DistanceFromBOH = Convert.ToInt32(line3(3))

		Airports(3).AirportCode = line4(0)
		Airports(3).AirportName = line4(1)
		Airports(3).DistanceFromLPL = Convert.ToInt32(line4(2))
		Airports(3).DistanceFromBOH = Convert.ToInt32(line4(3))

		Airports(4).AirportCode = line5(0)
		Airports(4).AirportName = line5(1)
		Airports(4).DistanceFromLPL = Convert.ToInt32(line5(2))
		Airports(4).DistanceFromBOH = Convert.ToInt32(line5(3))


	End Sub
	Sub AddAircraft()
		Dim line1() As String
		Dim line2() As String
		Dim line3() As String
		FileOpen(2, "Aircraft.txt", OpenMode.Input)
		line1 = LineInput(2).Split(",")
		line2 = LineInput(2).Split(",")
		line3 = LineInput(2).Split(",")
		FileClose(2)

		Aircrafts(0).Type = line1(0)
		Aircrafts(0).RunningCostPerSeat = line1(1)
		Aircrafts(0).FlightRange = line1(2)
		Aircrafts(0).MaxCapacityStandard = line1(3)
		Aircrafts(0).MinimumFirstClasss = line1(4)

		Aircrafts(1).Type = line2(0)
		Aircrafts(1).RunningCostPerSeat = line2(1)
		Aircrafts(1).FlightRange = line2(2)
		Aircrafts(1).MaxCapacityStandard = line2(3)
		Aircrafts(1).MinimumFirstClasss = line2(4)

		Aircrafts(2).Type = line3(0)
		Aircrafts(2).RunningCostPerSeat = line3(1)
		Aircrafts(2).FlightRange = line3(2)
		Aircrafts(2).MaxCapacityStandard = line3(3)
		Aircrafts(2).MinimumFirstClasss = line3(4)


	End Sub
End Module