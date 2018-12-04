function searchEmployee() {
	var search = $("#searchString").val();

	$.ajax({
		url: "Search",
		data: { searchString: search }
	}).done(function (data) {
		$("#employeeId").val(data.EmployeeID);
		$("#firstName").val(data.FirstName);
		$("#middleName").val(data.MiddleName);
		$("#lastName").val(data.LastName);
		$("#birthDate").val(JsonDateToIsoDate(data.BirthDate));
		$("#hireDate").val(JsonDateToIsoDate(data.HireDate));
		$("#department").val(data.Department);
		$("#jobTitle").val(data.JobTitle);
		$("#salary").val(data.Salary);
		$("#salaryType").val(data.SalaryType);
		$("#availableHours").val(data.AvailableHours);
	});
}

function updateEmployee() {
	var employeeId = $("#employeeId").val();
	var firstName = $("#firstName").val();
	var middleName = $("#middleName").val();
	var lastName = $("#lastName").val();
	var birthDate = $("#birthDate").val();
	var hireDate = $("#hireDate").val();
	var department = $("#department").val();
	var jobTitle = $("#jobTitle").val();
	var salary = $("#salary").val();
	var salaryType = $("#salaryType").val();
	var availableHours = $("#availableHours").val();

	$.ajax({
		url: "UpdateEmployee",
		dataType: "json",
		data: {
			EmployeeID: employeeId,
			FirstName: firstName,
			MiddleName: middleName,
			LastName: lastName,
			BirthDate: birthDate,
			HireDate: hireDate,
			Department: department,
			JobTitle: jobTitle,
			Salary: salary,
			SalaryType: salaryType,
			AvailableHours: availableHours
		}
	}).done(function(data) {
		if (data) {
			$("#successMessage").removeClass("hidden")
				.addClass("visible");
		}
		else {
			$("#errorMessage").removeClass("hidden")
				.addClass("visible");
		}
		});	
}

function clearSearch() {
	$("#searchString").val(null);
}

function clearInput() {
	$("#employeeId").val(null);
	$("#firstName").val(null);
	$("#middleName").val(null);
	$("#lastName").val(null);
	$("#birthDate").val(null);
	$("#hireDate").val(null);
	$("#department").val(null);
	$("#jobTitle").val(null);
	$("#salary").val(null);
	$("#salaryType").val(null);
	$("#availableHours").val(null);
}

function JsonDateToIsoDate(date) {
	return new Date(parseInt(date.replace('/Date(', ''))).toISOString().substr(0, 10);
}

