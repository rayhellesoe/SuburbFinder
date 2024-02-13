const Result = ({ suburb }) => {
    const { id, name, longitude, latitude } = suburb;
    console.log(id, name, longitude, latitude)

    return (
        <div>
            <p>The nearest suburb is</p>
            <h2>{name}</h2>
            <p>Longitude: {longitude} - Latitude: {latitude}</p>
        </div>
    )
}

export default Result