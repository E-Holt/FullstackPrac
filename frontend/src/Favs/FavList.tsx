import { useEffect, useState } from 'react';
import { EmsFavs } from '../types/EmsFavs';

function FavList() {
  const [favData, setFavData] = useState<EmsFavs[]>([]);

  useEffect(() => {
    const fetchFavData = async () => {
      const rsp = await fetch ('http://localhost:5254/fav');
      const favs = await rsp.json();
      setFavData(favs);
    };
  fetchFavData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">
          Em's Favourites!
        </h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name of thing</th>
            <th>Type of thing</th>
            <th>Rating of thing</th>
          </tr>
        </thead>
        <tbody>
          {favData.map((f) => (
            <tr key={f.favId}>
              <td>{f.favName}</td>
              <td>{f.favType}</td>
              <td>{f.favRating}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default FavList