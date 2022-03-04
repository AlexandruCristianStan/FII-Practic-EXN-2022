SELECT u.FirstName, 
	u.LastName,
	dl.ExpirationDate,
	v.VIN,
	v.RegistrationNumber,
	b.Name,
	m.Name,
	m.ModelYear,
	m.FuelType	
FROM Users u
	INNER JOIN DriverLicenses dl ON dl.UserID = u.ID
	INNER JOIN UserVehicles uv ON uv.UserID = u.ID
	INNER JOIN Vehicles v ON v.ID = uv.VehicleID
	INNER JOIN Models m ON m.ID = v.ModelID
	INNER JOIN Brands b ON b.ID = m.BrandID