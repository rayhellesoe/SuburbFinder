const suburbsReducer = (state = {}, action) => {
    switch (action.type) {
        case "suburbs/setNearestSuburb":
            return action.payload
        default:
            return state
    }
}

export const setNearestSuburb = (suburb) => {
    console.log('set nearest suburb', suburb)
    return ({
        type: "suburbs/setNearestSuburb",
        payload: suburb
    })
}

export default suburbsReducer