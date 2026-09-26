let currentDate = new Date();

document.addEventListener("DOMContentLoaded", function () {
    generateCalendar(currentDate.getFullYear(), currentDate.getMonth());
    highlightWorksheetDays();
});

function generateCalendar(year, month) {
    const calendarHeader = document.getElementById('schedule-header');
    const calendarElement = document.getElementById('schedule');
    const monthYearContainer = document.getElementById('schedule-month-year');
    calendarHeader.innerHTML = '';
    calendarElement.innerHTML = '';
    monthYearContainer.innerHTML = '';

    const weekDays = ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'];

    weekDays.forEach(day => {
        const headerCell = document.createElement('div');
        headerCell.textContent = day;
        headerCell.classList.add('schedule-day-header');
        calendarHeader.appendChild(headerCell);
    });

    const monthYearHeader = document.createElement('h2');
    monthYearHeader.textContent = `${new Date(year, month).toLocaleString('default', { month: 'long' })} ${year}`;
    monthYearContainer.appendChild(monthYearHeader);

    const firstDay = new Date(year, month, 1);
    const firstDayIndex = (firstDay.getDay() + 6) % 7;  // Adjust for Monday start
    const lastDay = new Date(year, month + 1, 0);
    const totalCells = firstDayIndex + lastDay.getDate();
    const totalRows = Math.ceil(totalCells / 7);

    for (let row = 0; row < totalRows; row++) {
        const rowElement = document.createElement('div');
        rowElement.classList.add('schedule-row');

        for (let col = 0; col < 7; col++) {
            const cellIndex = row * 7 + col;
            const dayElement = document.createElement('div');
            dayElement.classList.add('schedule-day');

            if (cellIndex >= firstDayIndex && cellIndex < totalCells) {
                const dayNumber = cellIndex - firstDayIndex + 1;
                dayElement.dataset.date = `${year}-${month + 1}-${dayNumber}`;
                dayElement.innerHTML = `<div class="day-number">${dayNumber}</div><div class="day-slots"></div>`;
                dayElement.addEventListener('click', function () {
                    displayDayDetails(year, month + 1, dayNumber);
                });
            }

            rowElement.appendChild(dayElement);
        }

        calendarElement.appendChild(rowElement);
    }
}

function highlightWorksheetDays() {
    worksheetData.forEach(worksheet => {
        const date = getDateFromWeekNumber(worksheet.weekNr, worksheet.weekDay);
        const dayElement = document.querySelector(`.schedule-day[data-date="${date.getFullYear()}-${date.getMonth() + 1}-${date.getDate()}"]`);

        if (dayElement) {
            dayElement.classList.add('has-worksheet');
            const slotsContainer = dayElement.querySelector('.day-slots');
            const slotElement = document.createElement('div');
            slotElement.textContent = `Slot: ${worksheet.timeSlot}`;
            slotElement.classList.add('slot');
            slotsContainer.appendChild(slotElement);
        }
    });
}

function displayDayDetails(year, month, day) {
    const detailsContainer = document.getElementById('day-details-content');
    detailsContainer.innerHTML = '';

    const worksheetsForDay = worksheetData.filter(worksheet => {
        const date = getDateFromWeekNumber(worksheet.weekNr, worksheet.weekDay);
        return date.getFullYear() === year && (date.getMonth() + 1) === month && date.getDate() === day;
    });

    if (worksheetsForDay.length === 0) {
        detailsContainer.innerHTML = '<p>No worksheets for this day.</p>';
    } else {
        worksheetsForDay.forEach(worksheet => {
            const worksheetElement = document.createElement('div');
            worksheetElement.classList.add('card', 'mb-4');
            worksheetElement.innerHTML = `
                <div class="card-header">
                    <h5 class="card-title">Worksheet #${worksheet.id}</h5>
                </div>
                <div class="card-body">
                    <p class="card-text"><strong>Time Slot:</strong> ${worksheet.timeSlot}</p>
                    <p class="card-text"><strong>Week Day:</strong> ${worksheet.weekDay}</p>
                    <p class="card-text"><strong>Week Number:</strong> ${worksheet.weekNr}</p>
                </div>
            `;
            detailsContainer.appendChild(worksheetElement);
        });
    }
}

function getDateFromWeekNumber(weekNumber, weekDay) {
    const jan1 = new Date(currentDate.getFullYear(), 0, 1);
    const daysOffset = (1 - jan1.getDay() + 7) % 7;
    const firstMonday = new Date(jan1);
    firstMonday.setDate(jan1.getDate() + daysOffset);

    const resultDate = new Date(firstMonday);
    resultDate.setDate(firstMonday.getDate() + (weekNumber - 1) * 7 + (weekDay - 1));

    return resultDate;
}

document.getElementById('prev-month').addEventListener('click', function () {
    currentDate.setMonth(currentDate.getMonth() - 1);
    generateCalendar(currentDate.getFullYear(), currentDate.getMonth());
    highlightWorksheetDays();
});

document.getElementById('next-month').addEventListener('click', function () {
    currentDate.setMonth(currentDate.getMonth() + 1);
    generateCalendar(currentDate.getFullYear(), currentDate.getMonth());
    highlightWorksheetDays();
});
