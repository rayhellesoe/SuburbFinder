import { useState } from 'react';
import './App.css';
import CoordinatesForm from './components/CoordinatesForm';
import Result from './components/Result'

function App() {
    const [nearestSuburb, setNearestSuburb] = useState(null);

    const getNearestSuburb = async (formData) => {
        try {
            const res = await fetch('nearestsuburb', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(formData)
            });

            const data = await res.json();

            setNearestSuburb(data)
        } catch (error) {
            console.error('Error fetching data:', error)
        }
    }

    //const coords = { "longitude": -90, "latitude": 90 }

    return (
        <main className="flex justify-center w-full">
            <div className="max-w-md">
                <h1 className="text-5xl font-bold mb-4">Suburb Finder</h1>
                <p className="mb-6">Input a set of coordinates to find the nearest suburb.</p>
                <CoordinatesForm getNearestSuburb={getNearestSuburb} />
                {nearestSuburb == null ? <></> : <Result suburb={nearestSuburb} />}
            </div>
        </main>
    )
}

export default App;