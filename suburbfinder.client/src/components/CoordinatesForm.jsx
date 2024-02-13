import { useState } from 'react'

const CoordinatesForm = ({ getNearestSuburb }) => {
    const [coords, setCoords] = useState({
        latitude: 0,
        longitude: 0,
    });

    const updateInput = (e) => {
        const { id, value } = e.target;
        setCoords((prevCoords) => ({ ...prevCoords, [id]: value }));
    }

    const handleSubmit = (e) => {
        e.preventDefault();
        getNearestSuburb(coords)
    }

    return (
        <form className="mx-auto" onSubmit={handleSubmit}>
            <div className="w-full md:w-1/2 inline-block p-2 text-left">
                <label htmlFor="latitude" className="block mb-2 text-sm font-medium text-gray-900 dark:text-green-900">Latitude</label>
                <input type="number" id="latitude" onChange={updateInput} className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5" placeholder="-100" required />
            </div>
            <div className="w-full md:w-1/2 inline-block p-2 text-left">
                <label htmlFor="longitude" className="block mb-2 text-sm font-medium text-gray-900 dark:text-green-900">Longitude</label>
                <input type="number" id="longitude" onChange={updateInput} className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5" placeholder="-100" required />
            </div>
            <div className="w-full inline-block px-2 text-left">
                <button type="submit" className="bg-amber-500 hover:bg-amber-600 text-white p-2 mt-2 w-full cursor-pointer rounded-lg">
                    Find Nearest Suburb
                </button>
            </div>
        </form>
    )
}

export default CoordinatesForm