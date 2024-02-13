import { useState } from 'react';
import './App.css';
import CoordinatesForm from './components/CoordinatesForm';
import Result from './components/Result'

function App() {
    const [nearestSuburb, setNearestSuburb] = useState(null);

    const getNearestSuburb = async (formData) => {
        try {
            const res = await fetch('getnearestsuburb', {
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

    const coords = { "longitude": -90, "latitude": 90 }

    return (
        <main>
            <CoordinatesForm onSubmit={getNearestSuburb} />
            <div className="bg-red-100 cursor-pointer" onClick={() => getNearestSuburb(coords)}>TEST API</div>
            {nearestSuburb == null ? <div>Enter coordinates</div> : <Result suburb={nearestSuburb} />}
        </main>
    )
}

export default App;